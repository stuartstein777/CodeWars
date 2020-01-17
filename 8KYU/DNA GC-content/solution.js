function gcContent(dna) {
  if(dna.length === 0)
     return 0;
  return dna.toLowerCase()
            .split("")
            .reduce((acc, i) => 'cg'.includes(i) ? acc + 1 : acc, 0)
            / dna.length * 100;
}