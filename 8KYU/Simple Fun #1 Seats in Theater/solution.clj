(ns kata.seats-in-theater)
(defn seats-in-theater [n-cols n-rows col row]
  (* (- (inc n-cols) col) (- n-rows row)))