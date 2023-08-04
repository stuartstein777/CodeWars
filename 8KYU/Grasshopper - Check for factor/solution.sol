// SPDX-License-Identifier: BSD-2-Clause
pragma solidity ^0.8.16;

contract Kata {
  function checkForFactor(int base, int factor) public pure returns (bool) {
    return base % factor == 0;
  }
}