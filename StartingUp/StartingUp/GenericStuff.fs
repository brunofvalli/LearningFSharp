namespace GenericStuff

module Generics =

    let add_stuff<'T> x y =
        printfn "%A" (x + y)
    let runMe() =

        // can only do one, once set it stays that way.
        // add_stuff<int> 2 5
        // add_stuff<float> 5.5 2.4
        
        add_stuff<string> "Hello " "-World"
