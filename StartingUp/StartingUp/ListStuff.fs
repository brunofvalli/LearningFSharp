namespace ListStuff

module Lists =
    let ListLiteral() = 
        let list1 = [1;2;3;4]

        list1 |> List.iter (printfn "Num %i")

        printfn "%A" list1

        let list2 = 5::6::7::[]
        printfn "%A" list2

        let list3 = [1..5]
        let list4 = ['a'..'g']

        printfn "%A %A" list3 list4

        let list5 = List.init 5 (fun i -> i * 2)
        printfn "%A" list5

        [for a in 1..5 do yield (a * a)] 
        |> printfn "List 6 %A"

        [for a in 1..20 do if a % 2 = 0 then yield a]
        |> printfn "List 7 %A"

        let list8 = [for a in 1..3 do yield! [a .. a + 2]] 

        list8 |> printfn "List 8 %A"
        
        list8.Length |> printfn "Length : %i" 

        list4.Item(4) |> printfn "Index 4 in list 4 %c"

        printfn "List4 head %c" list4.Head 
        printfn "List4 tail %A" list4.Tail

        list3 |> List.filter (fun x -> x % 2 = 0) |> printfn "Even numbers on list3 %A"
        list1 |> List.map (fun x -> (x * x)) |> printfn "Doubld list1 %A"
        List.sort([5;4;1;2]) |> printfn "Sorted list %A"

        printfn "Sum : %i" (List.fold (fun sum elem -> sum + elem) 0 [1;2;3])









        