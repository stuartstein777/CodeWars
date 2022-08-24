export function shortLongShort(a:string, b:string) {
    return a.length < b.length
      ? `${a}${b}${a}`
      : `${b}${a}${b}`
  }