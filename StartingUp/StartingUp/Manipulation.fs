namespace Manipulation

open System

module StringManipulation =
    let dynamicSpacing() =
        // negative number is before and possitive is after spacing
        printfn "%-5s %5s" "a" "b"
        printfn "%*s" 10 "a"
        

module  NumberManipulation = 
    let FloatLimitation() =
        let pi = 3.141592653589793238462643383279502884197169399375105820974944592307816406286M
        printfn "PI 4 digits: %.4f" pi
        printfn "PI max: %M" pi

