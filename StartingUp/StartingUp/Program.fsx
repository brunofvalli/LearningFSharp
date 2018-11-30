open System
#load "Manipulation.fs"
#load "HelloWorld.fs"
#load "BindStuff.fs"
#load "DoFunctions.fs"
#load "DoMath.fs"
#load "StringStuff.fs"
open Manipulation
open HelloWorld
open BindStuff
open DoFunctions
open DoMath
open StringStuff

StringManipulation.dynamicSpacing()
NumberManipulation.FloatLimitation()
BindValues.mutableValue()
BindValues.referenceCell()
Functions.DisplaySum()
Functions.RunFactorial()
Functions.DoubleList()
Functions.MultiNum()
Maths.basic()
Strings.doStuff()

// Question.AskName()

System.Console.ReadKey() |> ignore
