namespace DoFunctions

module Functions = 
    let getSum (x : int, y :int) : int = x + y
    let DisplaySum() = 
        let n1 = 5
        let n2 = 7
        printfn "%i + %i = %i" n1 n2 (getSum(n1, n2))
    let rec factorial x =
        if x < 1 then 1
        else x * factorial (x - 1)

    let RunFactorial() =
        let x = 4
        printfn "%i! = %i" x (factorial x)

    let randList = [1;2;3]

    let randList2 = List.map (fun x -> x * 2 ) randList

    let DoubleList() =
        printfn "Single list : %A" randList
        printfn "Double list : %A" randList2

        [5;6;7;8]
        |> List.filter (fun v -> (v % 2) = 0)
        |> List.map (fun x -> x * 2)
        |> printfn "Even Double %A"

    let mult_num x = x * 3
    let add_num y = y + 5

    let mult_add = mult_num >> add_num
    let add_mult = mult_num << add_num

    let MultiNum() =
        let a = 10
        printfn "mult_add of %i : %i" a (mult_add a)
        printfn "add_mult of %i : %i" a (add_mult a)

    

    