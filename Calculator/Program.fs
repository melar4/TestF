// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let add a b = a+b
    let sub a b = a-b
    let  IsLoopActive = true
    while( IsLoopActive) do
        Console.WriteLine("choose operation. \n 1. Addition \n 2.Substraction")
        let operation = Console.ReadLine()
        Console.WriteLine("choose first number")
        let first = Console.ReadLine()
        let firstInt :int = int32 first

        Console.WriteLine("choose second number")
        let second = Console.ReadLine()
        let secondInt :int = int32 second 
        match operation with
            | "1" -> printf "You have chosen addition %d %s" (add firstInt secondInt) "\n"
            | "2" -> printf "You have chosen substraction %d %s" (sub firstInt secondInt) "\n"
            | _ -> printf "Select 1 or 3"

        
        Console.WriteLine("Do you want to continue")
        IsLoopActive = Convert.ToBoolean(Console.ReadLine())
    
    
    Console.ReadKey() |> ignore
    0 // return an integer exit code
