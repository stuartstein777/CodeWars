def describe_age(a)
    s="You're a(n) "
    a<=12 ? s+"kid": a<=17 ? s+"teenager" : a<=64 ? s+"adult" : s+"elderly"
end