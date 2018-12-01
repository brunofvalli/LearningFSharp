namespace ExceptionStuff

module Exceptions =
    let divide x y = 
            try
                printfn "%.2f / %.2f = %.2f" x y (x / y)
            with
                | :? System.DivideByZeroException -> printfn "Can't Divide by Zero"

    let divideInt (x :int, y :int) = 
            try
                printfn "%i / %i = %i" x y (x / y)
            with
                | :? System.DivideByZeroException -> printfn "Can't Divide by Zero"

    let runMe() =
        divide 5.0 4.0
        divide 1.0 0.0

        divideInt (10,2)
        divideInt (10,0)