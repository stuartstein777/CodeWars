const _ = require('lodash');
function bigToSmall(arr){
  return _(arr).flatten().sort((a, b) => b-a).join(">");  
}