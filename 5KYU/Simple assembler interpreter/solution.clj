(ns simple-assembler
  (require [clojure.string :as str]))


(defn- is-register? [x]
  (nil? (re-find #"[0-9]" x)))

(defn asm-mov [registers register value]
  (cond (is-register? value) (assoc registers (keyword register) (get registers (keyword value)))
        :else (assoc registers (keyword register) (Integer/parseInt value))))

(defn asm-inc [registers register]
  (update registers (keyword register) inc))

(defn asm-dec [registers register]
  (update registers (keyword register) dec))

(defn asm-jnz [registers x y ip]
  (let [x-val (if (is-register? x) (get registers (keyword x)) (Integer/parseInt x))
        y-val (if (is-register? y) (get registers (keyword y)) (Integer/parseInt y))]
    (if (not (zero? x-val))
      (+ ip y-val)
      (inc ip))))

(defn simple-assembler
  ([instructions]
   (simple-assembler instructions {} 0))
  ([instructions registers ip]
   (if (>= ip (count instructions))
     registers
     (let [[operator register value] (str/split (nth instructions ip) #" ")]
       (cond (= operator "mov") (recur instructions (asm-mov registers register value) (inc ip))
             (= operator "inc") (recur instructions (asm-inc registers register) (inc ip))
             (= operator "dec") (recur instructions (asm-dec registers register) (inc ip))
             (= operator "jnz") (recur instructions registers (asm-jnz registers register value ip)))))))