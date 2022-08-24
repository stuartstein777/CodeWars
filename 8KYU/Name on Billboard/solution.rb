def billboard(name, price=30)
    name.split("").reduce(0) {|acc, i| acc+price}
end