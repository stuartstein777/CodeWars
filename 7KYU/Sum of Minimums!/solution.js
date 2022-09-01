function sumOfMinimums(arr) {
    return arr.reduce((acc, i) => acc + Math.min.apply(null, i), 0);
}