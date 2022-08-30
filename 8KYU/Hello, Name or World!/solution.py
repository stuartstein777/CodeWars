def hello(name = ""):
    if name == "":
        return "Hello, World!"
    return "Hello, " + name.lower().capitalize() + "!"