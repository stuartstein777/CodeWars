# Ruby

## Frequencies

Equivalent to `(frequencies)` in Clojure.

```ruby
s.chars.group_by(&:itself).transform_values(&:count)
```

## Partition

```ruby
[1, 2, 3, 4, 5, 6].each_slice(2).map {|n| n.to_a}

```

