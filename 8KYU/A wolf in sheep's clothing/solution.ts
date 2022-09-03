export function warnTheSheep(queue: string[]): string {
    var location = queue.reverse().indexOf('wolf');
    return (location == 0)
        ? "Pls go away and stop eating my sheep"
        : "Oi! Sheep number " + location + "! You are about to be eaten by a wolf!";
}