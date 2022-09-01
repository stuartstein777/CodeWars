"use strict";

let flattenAndSort = (array) =>[].concat.apply([], array).sort((a,b) => a - b);