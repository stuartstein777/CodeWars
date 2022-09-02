function arrayDiff(a, b) {
    return a.filter(n => !b.includes(n));
}