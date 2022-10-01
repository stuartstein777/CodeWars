defmodule Convertor do
  def dna_to_rna(dna) do
    String.replace(dna, "T", "U")
  end
end
