<?php
function twoArePositive(int $a, int $b, int $c): bool {
  return ($a > 0 && $b > 0 && $c <= 0) ||
         ($a > 0 && $b <= 0 && $c > 0) ||
         ($a <= 0 && $b > 0 && $c > 0);
}