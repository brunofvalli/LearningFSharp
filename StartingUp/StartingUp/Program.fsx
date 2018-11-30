open System
#load "Manipulation.fs"
#load "HelloWorld.fs"
#load "BindStuff.fs"
#load "DoFunctions.fs"
open Manipulation
open HelloWorld
open BindStuff
open DoFunctions

StringManipulation.dynamicSpacing()
NumberManipulation.FloatLimitation()
BindValues.mutableValue()
BindValues.referenceCell()
Functions.displaySum()
Functions.runFactorial()

// Question.AskName()

System.Console.ReadKey() |> ignore
