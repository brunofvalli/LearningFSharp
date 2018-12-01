namespace ClassStuff
open System.Web.UI.WebControls

module Classes =

    type Animal = class
        val Name : string
        val Height : float
        val Weigth : float

        new( name, heigh, weight) =
            {Name= name; Height = heigh; Weigth = weight;}

        member x.Run = 
            printfn "%s Runs" x.Name
    end

    type Dog(name, height, weight) = 
        inherit Animal( name, height, weight)

        member x.Bark =
            printfn "%s Barks" x.Name

    let runMe() = 
        let spot = new Animal("Spot", 20.5, 40.5)
        spot.Run

        let bowser = new Dog("Bowser", 20.5, 45.0)

        bowser.Run

        bowser.Bark
