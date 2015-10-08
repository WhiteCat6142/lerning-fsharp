open System

(*See
http://shingetsu.ygch.net/thread.cgi/%E3%83%97%E3%83%AD%E3%82%B0%E3%83%A9%E3%83%9F%E3%83%B3%E3%82%B0%E5%85%A5%E9%96%80/99fb6418
*)

let parse (x:string) =
 match Int32.TryParse(x) with
 |(true,int) -> int
 |_ -> 0

let main (max:int) (s:string) =
 let a = s.Split ','|>Seq.map parse
 let l =
  a
  |>Seq.fold (fun x y -> if (List.head x) = y then x else y::x) [(Seq.head a)]
  |>List.toSeq
  |>Seq.groupBy(fun x -> x)
  |>List.ofSeq
  |>List.sortBy fst
 if List.length l > max then printfn "入力エラー" else l|>List.iter (fun x -> printfn "%dは%dグループあります" (fst x) (Seq.length (snd x)));; 
 
let main2 =
 printfn "何種類の整数を使いますか？"
 let max = parse (Console.ReadLine())
 printfn "1以上%d以下の整数を何個でも入力してください" max
 let l =
  Console.ReadLine().Split ','
  |>Seq.map parse
  |>Seq.fold (fun x y -> if (List.isEmpty x || List.head x <> y) then y::x else x) []
  |>Seq.groupBy(fun x -> x)
  |>Seq.sortBy fst
 if Seq.length l > max then printfn "入力エラー"
  else l|>Seq.iter (fun x -> printfn "%dは%dグループあります" (fst x) (Seq.length (snd x)));; 
