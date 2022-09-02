function validateHello(greetings) {
    return greetings.toLowerCase().includes("hello") ||
           greetings.toLowerCase().includes("ciao")  ||
           greetings.toLowerCase().includes("salut") ||
           greetings.toLowerCase().includes("hallo") ||
           greetings.toLowerCase().includes("hola")  ||
           greetings.toLowerCase().includes("ahoj")  ||
           greetings.toLowerCase().includes("czesc");
}