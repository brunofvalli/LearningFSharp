namespace SequenceStuff

module Sequences =
    let runMe() = 
        let seq1 = seq { 1..100 }

        // middle number is the amount we are increasing more
        let seq2 = seq { 0 .. 2 .. 50}

        let seq3 = seq { 50 .. 1 }

        // only partial sequence is created since we don't need the whole thing
        printfn "%A" seq2

        // Force the whole list to be created.
        Seq.toList seq2 |> List.iter (printfn "Num : %i")

        let isPrime n =
            let rec check i = 
                i > n/2 || (n % i <> 0 && check (i + 1))
            check 2

        let prime_seq = seq { for n in 1..500 do if isPrime n then yield n }

        printfn "Prime list: %A" prime_seq

        Seq.toList prime_seq |> printfn "Prime list: %A" 

        
