function minValue(values){
    return Number([...new Set(values)].sort().reduce((acc, i) => acc + String(i), ""));
  }