fn dna_strand(dna: &str) -> String {
    return dna.chars()
              .map(|x| match x { 
                  'A' => 'T',
                  'C' => 'G',
                  'G' => 'C',
                  'T' => 'A',
                  _ => x
                  }).collect();
}