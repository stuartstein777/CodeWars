component {
    numeric function maxMultiple(required numeric d, required numeric b) {
        return b - b % d;
    }
}
