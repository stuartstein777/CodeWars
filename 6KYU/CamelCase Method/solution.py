def camel_case(s):
    words = s.split(" ")
    capitalized = [word.capitalize() for word in words]
    return "".join(capitalized)