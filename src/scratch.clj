(->> "HaHaHahahaHaHa"
     (take-nth 2)
     (partition-by identity)
     count)
