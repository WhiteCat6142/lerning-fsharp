let rec gcd m n =
 man tch n with
  |0 -> m
  |_ when m<n -> (gcd n m)
  |_ -> (gcd n (m%n));;

let lcm m n = (m*n) / (gcd m n);;


//http://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=0006&lang=jp

printf "%s" (Console.ReadLine()|>Seq.toList|>List.rev |> String.Concat );;
