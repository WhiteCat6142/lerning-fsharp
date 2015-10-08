let printseq s = s|>Seq.take 10|>Seq.iter (printf "%A ")

(* 平方数 *)
seq { for i in 1 ..100  -> i * i }
|>printseq;;
(* フィボナッチ数列 *)
Seq.unfold (fun (a,b) -> Some(a+b, (b, a+b))) (1,1)
|>printseq;;

(*素数*)
let check x l=
 l|>List.filter (fun i -> x%i=0)|>List.isEmpty
seq { for i in 2 .. 1000 -> i}
|>Seq.fold(fun x y -> if(check y x) then y::x else x) [2;]
|>List.rev
|>printseq;;

(*素数v2*)
let sf ( f: 'T -> 'T list -> bool) a b = Seq.fold (fun x y ->if(f y x) then y::x else x) a b
let check2 x l = not(List.exists (fun i -> x%i=0) l)
seq{3..2..10000}|>sf check2 [2;]|>List.rev|>printseq;;
