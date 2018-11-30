namespace ConditionalStuff

module Conditionals =
    let IfStatement() = 
        let age = 8

        if age < 5 then
            printfn "Preschool"
        elif age = 5 then
            printfn "Kindergarden"
        else 
            printfn "Go to College"

        let gpa = 3.9
        let income = 15000

        printfn "College Grant : %b" ((gpa >= 3.8) || (income < 50000))

        printfn "Not true: %b" (not true)

        let grade2: string =
            match age with
            | age when age < 5 -> "Preschool"
            | 5 -> "Kindergarden"
            | age when ((age > 5) && (age <= 18)) -> (age - 5).ToString()
            | _ -> "College" // this means all

        printfn "Grade 2 : %s" grade2


        (*Multiline 
        comment*)

        (* printfn "College Grant : %b" ((gpa >= 3.8) || *)