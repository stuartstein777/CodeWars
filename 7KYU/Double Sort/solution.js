function dbSort(a){
    var numbers = a.filter(f => typeof(f) == 'number').sort((a, b) => a - b);
    var strings = a.filter(f => typeof(f) == 'string').sort();
    return numbers.concat(strings);
}