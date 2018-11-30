namespace DoMath

module Maths =
    let Basic() =
        let a = 5;
        let b = 4;
        let c = 5.0;
        let d = 4.0
        printfn "%i + %i = %i" a b (a + b)
        printfn "%i - %i = %i" a b (a - b)
        printfn "%i * %i = %i" a b (a * b)
        printfn "%i / %i = %i" a b (a / b)
        printfn "%i %% %i = %i" a b (a % b)
        printfn "%f ^ %f = %f" c d (c ** d)

        let number = 2
        printfn "A int:%A" (number.GetType())
        printfn "A float : %.2f" (float number) // casting
        printfn "A float : %i" (int 3.14) //casting

        // 
        printfn "abs 4.5 : %i" (abs -1)
        printfn "ceil 4.5 : %f" (ceil 4.5)
        printfn "floor 4.5 : %f" (floor 4.5)
        printfn "log 2.74.5 : %f" (log 4.5)