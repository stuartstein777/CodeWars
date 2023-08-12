def shortLongShort(a: String, b: String): String = 
  if (a.length < b.length) {
    return a + b + a;
  } else {
    return b + a + b;
  }