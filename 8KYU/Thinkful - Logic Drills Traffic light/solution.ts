export function updateLight(current: string): string {
    if(current == "red") return "green";
    if(current == "yellow") return "red";
    return "yellow";
}