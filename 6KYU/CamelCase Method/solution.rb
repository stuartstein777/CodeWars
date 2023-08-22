class String
    def camelcase
      self.split(" ")
          .map {|w| w.capitalize}
          .join("")    
    end
end