let fizzbuzz x =
  match(x%3,x%5) with
   |(0,0) -> "fizz buzz"
   |(0,_) -> "fizz"
   |(_,0) -> "buzz"
   |(_,_) -> string x

[1..100]
 |>List.map fizzbuzz
 |>List.iter (printfn "%s");; 
