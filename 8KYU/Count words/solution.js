function countWords(str) {
    if (str === null || str.trim() === '')
      return 0;
    var reg = new RegExp(/[\s+﻿]/);
    var collapseSpaces =  /\s+/g
    return str.trim()
              .replace(collapseSpaces, " ")
              .split(reg)
              .length;
}