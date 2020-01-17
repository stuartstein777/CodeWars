function expressionMatter(a, b, c) {
  return Math.max.apply(null, [...[a * (b + c),
                   a * (b * c),
                   a * b * c,
                   a + b + c,
                   (a + b) * c,
                   (a * b) * c,
                   (a * b) + c]]);
}