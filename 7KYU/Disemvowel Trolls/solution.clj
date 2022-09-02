(ns disemvowel-trolls)

(defn disemvowel
  [string]
  (apply str (filter #(not (#{\a \A \e \E \i \I \o \O \u \U} %)) string)))