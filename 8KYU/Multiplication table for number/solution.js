function multiTable(number) {
  return Array(10).fill()
                  .map((_, i) => `${i+1} * ${number} = ${(i+1)*number}`)
                  .join("\n");
}