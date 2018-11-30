namespace DoFunctions

module Functions = 
    let getSum (x : int, y :int) : int = x + y
    let displaySum() = 
        let n1 = 5
        let n2 = 7
        printfn "%i + %i = %i" n1 n2 (getSum(n1, n2))
    let rec factorial x =
        if x < 1 then 1
        else x * factorial (x - 1)

    let runFactorial() =
        let x = 4
        printf "%i! = %i" x (factorial x)

    