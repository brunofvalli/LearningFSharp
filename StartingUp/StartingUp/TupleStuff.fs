namespace TupleStuff

module Tuples =
    let runMe() =
        let avg (w, x, y, z) : float =
            let sum = w + x + y + z
            sum / 4.0
        
        printfn "Avg : %f" (avg (1.0,2.0,3.0,4.0))

        let myData = ("Derek", 42, 6.25)

        let (name, age, _) = myData

        printfn "Name : %s" name