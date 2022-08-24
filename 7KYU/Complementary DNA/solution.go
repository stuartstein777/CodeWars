package kata

import (
	"strings"
)

func DNAStrand(dna string) string {
	dna = strings.Replace(dna, "T", "a", -1)
	dna = strings.Replace(dna, "A", "t", -1)
	dna = strings.Replace(dna, "G", "c", -1)
	dna = strings.Replace(dna, "C", "G", -1)
	return strings.ToUpper(dna)
}
