System
let cut x = (ceil (x/1000.0))*1000.0
let main x = Seq.fold (fun i j -> cut(i*1.05)) 100000.0 {1..x}
printfn "%f" (main (int(Console.ReadLine())))

(*【やってみよう】借金地獄 | Aizu Online Judge

http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0007&lang=jp*)
