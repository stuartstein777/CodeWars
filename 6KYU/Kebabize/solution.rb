def kebabize(str)
  (str.gsub(/[^A-Za-z]/, "").split /(?=[A-Z])/).map {|x| x.downcase }.join("-")
end