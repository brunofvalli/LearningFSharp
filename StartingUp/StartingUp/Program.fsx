open System
#load "Manipulation.fs"
#load "HelloWorld.fs"
#load "BindStuff.fs"
#load "DoFunctions.fs"
#load "DoMath.fs"
#load "StringStuff.fs"
#load "LoopStuff.fs"
#load "ConditionalStuff.fs"
open Manipulation
open HelloWorld
open BindStuff
open DoFunctions
open DoMath
open StringStuff
open LoopStuff
open ConditionalStuff

StringManipulation.dynamicSpacing()
NumberManipulation.FloatLimitation()
BindValues.mutableValue()
BindValues.referenceCell()
Functions.DisplaySum()
Functions.RunFactorial()
Functions.DoubleList()
Functions.MultiNum()
Maths.Basic()
Strings.DoStuff()
//Loops.WhileLoops()
Loops.ForLoops()
Conditionals.IfStatement()

// Question.AskName()

System.Console.ReadKey() |> ignore
