export function sumDigits(n: number): number {
    let res: string = Math.abs(n).toString();
    let sum: number = 0;

    for (let i = 0; i < res.length; i++) {
        sum += Number(res[i]);
    }

    return sum;
}
