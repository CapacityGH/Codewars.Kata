export function getMiddle(s: string) {
    let middle: number = Math.floor(s.length / 2);
    return s.length % 2 === 0 ? s[middle - 1] + s[middle] : s[middle];
}
