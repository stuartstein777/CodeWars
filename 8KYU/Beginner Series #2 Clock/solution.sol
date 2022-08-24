pragma solidity ^0.4.19;

contract Kata {
  function past(int h, int m, int s) public pure returns (int) {
    return s * 1000 + m * 60000 + h * 3600000;
  }
}