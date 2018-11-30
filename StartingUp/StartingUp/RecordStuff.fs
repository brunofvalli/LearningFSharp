namespace RecordStuff

module Records =

    type Customer = 
        {Name : string;
        Balance : float}

    let runMe() =
        let bob = { Name = "Bob Smith";Balance = 101.50 }
        printfn "%s owes us %f" bob.Name bob.Balance
