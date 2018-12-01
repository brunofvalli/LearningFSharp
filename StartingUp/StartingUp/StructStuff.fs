namespace StructStuff

module Structs =

    type Rectangle  = struct
        val Length : float
        val Width : float

        new (length, width) = 
            {Length = length; Width = width}   
    end

    let runMe() =
        let area(shape: Rectangle) = 
            shape.Length * shape.Width

        let rect = new Rectangle(5.0, 6.0)

        let rect_area = area rect

        printfn "Rectangle of %.2f by %.2f has an area of %.2f" rect.Length rect.Width rect_area
