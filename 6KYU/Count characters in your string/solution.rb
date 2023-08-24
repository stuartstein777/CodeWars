def count_chars(s)
  s.chars.group_by(&:itself).transform_values(&:count)
end