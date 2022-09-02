(ns brainfuck)

(defn increment [n]
  (mod (inc n) 256))

(defn decrement [n]
  (mod (dec n) 256))

(defn reducer [{:keys [instr open] :as state} i]
  (cond
    (= i \[) (-> state
                 (update :open conj instr)
                 (update :instr inc))
    (= i \]) (-> state
                 (update :open pop)
                 (update :instr inc)
                 (update :res assoc instr (peek open))
                 (update :res assoc (peek open) instr))
    :else    (update state :instr inc)))

(defn build-jmp-table [code]
  (->> code
       (reduce reducer {:instr 0 :open [] :res {}})
       :res))


(defn get-fwd-jump-target [{:keys [dp memory ip jmp-table]}]
  (let [byte-at-dp (memory dp 0)]
    (if (zero? byte-at-dp)
      (inc (jmp-table ip))
      (inc ip))))

(defn get-bkwd-jump-target [{:keys [dp memory ip jmp-table]}]
  (let [byte-at-dp (memory dp 0)]
    (if (zero? byte-at-dp)
      (inc ip)
      (inc (jmp-table ip)))))

(defn get-input [input]
  (if (empty? input)
    nil
    (int (first input))))


(defn execute-string
  "Evaluate the Brainfuck source code in `source` using `input` as a source of
  characters for the `,` input command.

  Either returns a sequence of output characters, or `nil` if there was
  insufficient input."
  [code input]
  (let [code (seq code)
        jmp-table (build-jmp-table code)
        code-len (count code)]
    (loop [vm {:ip        0
               :input     (seq input)
               :jmp-table jmp-table
               :output    []
               :dp        0
               :memory    {}}]
      (if (= (:ip vm) code-len)
        (apply str (vm :output))
        (let [cur (nth code (:ip vm))]
          (condp = cur
            \+ (recur (-> vm
                          (update :ip inc)
                          (update-in [:memory (vm :dp)] (fnil increment 0))))

            \- (recur (-> vm
                          (update :ip inc)
                          (update-in [:memory (vm :dp)] (fnil decrement 0))))

            \> (recur (-> vm
                          (update :ip inc)
                          (update :dp inc)))

            \< (recur (-> vm
                          (update :ip inc)
                          (update :dp dec)))

            \. (recur (-> vm
                          (update :ip inc)
                          (update :output conj (char (get-in vm [:memory (vm :dp)] 0)))))

            \, (let [input (get-input (vm :input))]
                 (if (nil? input)
                   nil
                   (recur (-> vm
                              (update :ip inc)
                              (assoc-in [:memory (vm :dp)] input)
                              (update :input rest)))))

            \[ (recur (let [new-ip (get-fwd-jump-target vm)]
                        (assoc-in vm [:ip] new-ip)))

            \] (recur (let [new-ip (get-bkwd-jump-target vm)]
                        (assoc-in vm [:ip] new-ip)))

            (recur (-> vm (update :ip inc)))))))))