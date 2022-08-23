function betterThanAverage(classPoints, yourPoints) {
    return yourPoints > classPoints.reduce((acc, i) => acc + i, 0) / classPoints.length
  }
  