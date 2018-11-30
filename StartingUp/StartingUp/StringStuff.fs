namespace StringStuff

open System

module Strings =

    let str3 = """ "I ignore double string quotes and backslashes" """

    let upper_str = String.collect (fun c -> sprintf"%c, " c) "commas"

    
        

    let DoStuff() = 
        printfn "Length : %i" (String.length str3)
        printfn "1st Word : %s" (str3.[0..3])
        printfn "String collect %s" upper_str

        printfn "Any upper %b" (String.exists (fun c -> Char.IsUpper(c)) str3 )
        printfn "Number : %b" (String.forall (fun c -> Char.IsDigit(c)) "1234" )

        let string1 = String.init 10 (fun i -> i.ToString()) 
        
        String.collect (fun c -> sprintf"%c, " c) string1 
            |> printfn "Count to 10 : %s" 

        String.iter(fun c -> printfn "%c" c) "Print Me"
        

