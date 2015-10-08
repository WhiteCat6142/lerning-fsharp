let main name = File.ReadAllLines name|>Seq.iter (printfn "%A");;
