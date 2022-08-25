(ns math-parser
  (require [clojure.string :as str]))


(defn is-operator? [token]
  (boolean (#{\+ \/ \* \- \( \)} token)))

(defn dash-type [expr loc]
  (let [prev (nth expr (dec loc) \-)]
    (if (or (= \) prev) (Character/isDigit ^char prev))
      :subtraction
      :negation)))

(defn get-number [expr loc]
  (->> (drop loc expr)
       (take-while #(or (Character/isDigit ^char %) (= % \.)))
       (apply str)))

(defn tokenize [expr]
  (let [expr (str/replace expr #" " "")]
    (loop [tokens [] loc 0]
      (if (= loc (count expr))
        tokens
        (let [token (nth expr loc)]
          (cond (Character/isDigit ^char token)
                (let [num (get-number expr loc)]
                  (recur (conj tokens (Double/parseDouble num)) (+ loc (count num))))
                :else
                (recur (conj tokens
                             (if (= \- token)
                               (if (= :subtraction (dash-type expr loc)) \- \~)
                               token))
                       (inc loc))))))))

;; Convert to RPN

(def operator-precedence
  {\( 1 \) 1 \+ 2 \- 2 \* 3 \/ 3 \~ 4})

;; Returns precedence of op1 compared to op2.
;; e.g. (precedence \* \+) => :higher
(defn precedence [op1 op2]
  (cond (< (operator-precedence op1) (operator-precedence op2)) :lower
        (> (operator-precedence op1) (operator-precedence op2)) :higher
        :else :same))

(defn pop-brackets [{:keys [output op-stack]}]
  (let [ops (take-while #(not= % \() op-stack)
        output (apply conj output ops)]
    {:output output :op-stack (vec (drop (inc (count ops)) op-stack))}))

(defn pop-lower-or-same-precedence [{:keys [output op-stack]} t]
  (if (or (empty? op-stack) (= (precedence t (first op-stack)) :higher))
    {:output output :op-stack (concat [t] op-stack)}
    (let [ops (take-while #(not= :higher (precedence t %)) op-stack)
          output (apply conj output ops)
          op-stack (concat [t] (drop (count ops) op-stack))]
      {:output output :op-stack op-stack})))

(defn to-rpn [tokens]
  (let [acc (reduce (fn [acc t]
                      (cond (number? t)
                            (update acc :output conj t)

                            (or (= t \() (= t \~))
                            (update acc :op-stack #(concat [t] %))

                            (= t \))
                            (pop-brackets acc)

                            :else
                            (if (= :higher (operator-precedence t (first (acc :op-stack))))
                              (update acc :op-stack #(concat [t] %))
                              (pop-lower-or-same-precedence acc t))))
                    {:output [] :op-stack []}
                    tokens)]
    (apply conj (:output acc) (:op-stack acc))))

;; Evaluate RPN

(defn get-function [i]
  (cond (= i \+) +
        (= i \-) -
        (= i \*) *
        (= i \/) /))

(defn rpn-reducer [operand-stack i]
  (cond (number? i)
        (concat [i] operand-stack)

        (= \~ i)
        (concat [(- (first operand-stack))] (drop 1 operand-stack))

        :else
        (let [op1 (first operand-stack)
              op2 (second operand-stack)
              res ((get-function i) op2 op1)]
          (concat [res] (drop 2 operand-stack)))))

(defn calc-rpn [rpn]
  (->> (reduce rpn-reducer [] rpn)
       (first)))

(defn calc [expression]
  (->> expression
       (tokenize)
       (to-rpn)
       (calc-rpn)))