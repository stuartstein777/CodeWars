export function enough(cap: number, on: number, wait: number): number {
    return on + wait <= cap
          ? 0
          : wait - (cap - on);
}