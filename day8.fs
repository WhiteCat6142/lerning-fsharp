open System

let rec p depth n = 
 match depth with
 |_ when (n<0)||(n>depth*9) ->0
 |0 ->1
 |_ -> Seq.sum (seq{for i in 0..9 -> (p (depth-1) (n-i))})

Seq.initInfinite(fun _->Console.ReadLine())|>Seq.takeWhile ((<>)null)
|>Seq.iter (fun s->printfn "%d" (p 4 (int s)))

(*【やってみよう】４つの整数の和 | Aizu Online Judge

http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0008&lang=jp*)
