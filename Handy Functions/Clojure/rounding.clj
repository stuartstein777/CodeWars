(defn round-to-decimal-places [value decimal-places]
  (let [scale (Math/pow 10 decimal-places)]
    (/ (double (Math/round (* value scale))) scale)))