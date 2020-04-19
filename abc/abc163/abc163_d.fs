// https://atcoder.jp/contests/abc163/submissions/12149192

let MOD = 1000000007L

let [| N; K |] = stdin.ReadLine().Split() |> Array.map int64

let rec resolver s i =
    if i = N + 2L then s
    else
        let min = i * (i - 1L) / 2L
        let max = i * (2L * N - i + 1L) / 2L
        resolver ((s + max - min + 1L) % MOD) (i + 1L)

resolver 0L K |> stdout.WriteLine
