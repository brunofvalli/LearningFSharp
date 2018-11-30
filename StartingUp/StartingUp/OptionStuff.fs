namespace OptionStuff

module Options =
    let runMe() =
        let divide x y =
            match y with
            | 0 -> None
            | _ -> Some(x/y)

        if (divide 5 0).IsSome then
            printfn "5 / 0 = %A" ((divide 5 0).Value)
        elif (divide 5 0).IsNone then
            printfn "Can't Divide by Zero"
        else
            printfn "Something happened"