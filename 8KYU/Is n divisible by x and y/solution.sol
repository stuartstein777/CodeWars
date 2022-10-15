// SPDX-License-Identifier: BSD-2-Clause
pragma solidity ^0.8.16;

contract Kata {
  function isDivisible(int n, int x, int y) public pure returns (bool) {
    return n % x == 0 && n % y == 0;
  }
}