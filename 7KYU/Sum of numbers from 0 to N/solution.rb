class SequenceSum
    def self.show_sequence(n)
      if n == 0
        "0=0"
      elsif n < 0
        n.to_s + "<0"
      else
        (0..n).to_a.join("+") + " = " + (0..n).sum.to_s
      end
    end
  end