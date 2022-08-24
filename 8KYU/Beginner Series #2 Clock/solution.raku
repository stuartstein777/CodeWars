use v6;
unit module Solution;

sub past(Int $h, Int $m, Int $s --> Int) is export {
    $s * 1000 + $m * 60000 + $h * 3600000;
}