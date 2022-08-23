betterThanAverage = (classPoints, yourPoints) ->
  ((classPoints.reduce (acc,i) -> acc + i) / classPoints.length) <= yourPoints;