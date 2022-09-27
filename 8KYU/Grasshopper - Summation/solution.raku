use v6;
unit module Solution;

sub summation(Int $n --> Int) is export {
    return Int($n*($n+1)/2)
}