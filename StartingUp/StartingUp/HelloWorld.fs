namespace HelloWorld

open System

module Question =
    let AskName() =
        printf "Enter your name:"
        let name = Console.ReadLine()
        printfn "Hello %s" name
