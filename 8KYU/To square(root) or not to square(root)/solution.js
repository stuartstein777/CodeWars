function squareOrSquareRoot(array) {
    return array.map(a => Number.isInteger(Math.sqrt(a))
                            ? Math.sqrt(a)
                            : a *a);  
}