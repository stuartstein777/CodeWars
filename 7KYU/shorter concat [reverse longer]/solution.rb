def shorter_reverse_longer(a,b)
    a.length < b.length ? a + b.reverse + a : b + a.reverse + b
  end