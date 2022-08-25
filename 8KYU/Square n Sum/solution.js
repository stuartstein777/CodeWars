function squareSum(numbers){
    return numbers.reduce((acc, i) => acc + (i*i), 0);
}