function hello(name) {
  return (name === '' || name === null || name === undefined)
            ? "Hello, World!"
            : "Hello, " + name[0].toUpperCase() + name.substr(1).toLowerCase() + "!";
}