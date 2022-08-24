pragma solidity ^0.4.19;

contract ThirdAngle {
  function otherAngle(int angle1, int angle2) returns (int) {
    // TODO your code here
    int a1 = angle1;
    int a2 = angle2;
    return 180 - a1 - a2;
  }
}
