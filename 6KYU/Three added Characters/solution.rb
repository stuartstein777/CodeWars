# Average runtime: ?? ms

def added_char(s1, s2) 
    s1freqs = s1.chars.group_by(&:itself).transform_values(&:count)
    s2freqs = s2.chars.group_by(&:itself).transform_values(&:count)

    s2freqs.each do |key, value|
        if s1freqs[key] == nil or s1freqs[key] < s2freqs[key]
        return key
        end
    end
end