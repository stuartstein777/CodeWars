export default function isSquare(n: number): boolean {
    return (n - ((Math.floor(Math.sqrt(n)) * Math.floor(Math.sqrt(n))))) === 0;
 };
 