function spacify(str) {
    return str.split('').reduce((acc, i) => acc += i + " ", "").trim();
}