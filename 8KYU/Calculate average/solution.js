const findAverage = (array) => array.length == 0
                                 ? 0
                                 : array.reduce((acc,i) => acc + i, 0) / array.length;
