export function DNAtoRNA(dna: string): string {
    return dna.replace(/T/gi, "U");
}