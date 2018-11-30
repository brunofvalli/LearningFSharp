namespace EnumStuff

module Enums =

    type emotion =
    | Joy = 0
    | Fear = 1
    | Anger = 2
    let Run() =
        let myFeeling = emotion.Joy

        match myFeeling with
        | Joy -> printfn "I'm joyful" 
        | Fear -> printfn "I'm fearful"
        | Anger -> printfn "I'm angry"

