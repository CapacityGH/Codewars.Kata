export function drawStairs(n: number): string {
    let result: string = "";
    for (let i = 0; i < n; i++) {
        result += " ".repeat(i) + "I" + (i === n - 1 ? "" : "\n");
    }
    return result;
}
