# Ruby

## Frequencies

Equivalent to `(frequencies)` in Clojure.

```ruby
s.chars.group_by(&:itself).transform_values(&:count)
```

## Partition

```ruby
number.chars.each_slice(2).map {|n| n.join.to_i.chr}.join
```

def solution(n)
  s = n.to_s
  len = s.length
  if len <= 3
    return n.to_s
  else if len % 3 == 0
    return s.chars.each_slice(3).map{|x| x.join("")}.join(",")
  elsif len-1 %3 == 0
    #return s.chars[1..].each_slice(3).map{|x| x.join("")}.reverse.join(",")
  else
    #return s[0] + s[1] + s.chars[2..].each_slice(3).map{|x| x.join("")}.reverse.join(",")
  end
end