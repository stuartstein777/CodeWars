export function betterThanAverage(classPoints: number[], yourPoints: number) : boolean {
    return yourPoints > classPoints.reduce((acc, i) => acc + i, 0) / classPoints.length
  }