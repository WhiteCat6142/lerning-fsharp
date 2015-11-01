open System
let parse (x:string) =
 match Int32.TryParse(x) with
 |(true,int) -> int
 |_ -> 0

let main =
 seq{for x in 1..10 -> Console.ReadLine()}
  |>Seq.map parse
  |>Seq.sortBy (~-) 
  |>Seq.take 3
  |>Seq.iter (printfn "%d")


(*
http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0001&lang=jp
*)
