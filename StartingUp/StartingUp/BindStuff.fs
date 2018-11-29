namespace BindStuff
module BindValues =
    let mutableValue() =
        let mutable weight = 175
        printfn "Weight: %i (B4)" weight
        weight <- 170
        printfn "Weight: %i" weight

    let referenceCell() = 
        let changeMe = ref 10 
        printfn "Change: %i (B4)" ! changeMe
        changeMe := 50
        printfn "Change: %i" ! changeMe
