open System

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
