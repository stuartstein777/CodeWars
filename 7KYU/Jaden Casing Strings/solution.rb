class String
    def toJadenCase
      self.split.map { |w| w.capitalize }.join(" ")
    end
end