namespace LoopStuff

open System

module Loops = 
    let WhileLoops() =
        let magicNum = "7"
        let mutable guess = ""

        while not (magicNum.Equals(guess)) do
            printf "Guess the Number:"
            guess <- Console.ReadLine();

        printfn "You Guessed the Number"

    
    let ForLoops() =
        for i = 1 to 10 do
            printfn "%i" i

        for i = 10 downto 1 do
            printfn "%i" i

        for i in [1..10] do
            printfn "%i" i

        [1..10] |> List.iter (printfn "Num : %i")

        let sum = List.reduce (+) [1..10]
        printfn "List.reduce Sum %i" sum