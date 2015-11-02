open System
let parse (x:string) =
 match Int32.TryParse(x) with
 |(true,int) -> int
 |_ -> 0

let c i =
 let a= Console.ReadLine().Split ' '|>Seq.map parse|>Seq.sort|>Seq.toArray
 if (a.[0]a.[0] + a.[1]a.[1] = a.[2]*a.[2])then "YES" else "NO"

let main =
 let x = parse (Console.ReadLine())
 seq{for i in 1..x -> c i}|>Seq.iter (printfn "%s")
main;;

(* 【やってみよう】正三角形 | Aizu Online Judge

http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0003&lang=jp *)
