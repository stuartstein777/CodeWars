# Ruby

## Frequencies

Equivalent to `(frequencies)` in Clojure.

```ruby
s.chars.group_by(&:itself).transform_values(&:count)
```

