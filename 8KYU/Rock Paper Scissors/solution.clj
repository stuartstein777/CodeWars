(ns rock-paper-scissors)

(def beats 
{"rock" "scissors"
 "paper" "rock"
 "scissors" "paper"})
 
(defn rps [p1 p2]
  (cond (= p1 p2) "Draw!"
        (= (beats p1) p2) "Player 1 won!"
        :else "Player 2 won!"))