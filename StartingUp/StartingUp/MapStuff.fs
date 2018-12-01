namespace MapStuff

module Maps =
    let runMe() =
        let customers = 
            Map.empty.
                Add("Bob Smith", 100.50).
                Add("Sally Marks", 50.25)
        
        printfn "# of customers %i" customers.Count

        let cust = customers.TryFind "Bob Smith"
        match cust with
        | Some x -> printfn "Balance : %.2f" x
        | None -> printfn "Not Found"

        printfn "Customers : %A" customers

        if customers.ContainsKey "Bob Smith" then
            printfn "Bob Smith was found"


        printfn "Bobs Balance : %.2f" customers.["Bob Smith"]

        let custs2 = Map.remove "Sally Marks" customers
        
        printfn "# of Customers %i" custs2.Count
