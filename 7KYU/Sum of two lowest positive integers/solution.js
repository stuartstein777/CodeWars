function sumTwoSmallestNumbers(numbers) {  
    return numbers.sort((a, b) => a-b).slice(0, 2).reduce((acc, i) => acc + i, 0);
}