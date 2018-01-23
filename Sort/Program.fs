// Learn more about F# at http://fsharp.org

open System


 let sort1 l = 
        printfn "sort1 sort %A" l
 let sort2 l = 
        printfn "sort2 sort %A" l
 
type Strategy(SortMethod) = 
        member this.SortMethod with get() = SortMethod    
        member this.Sort(list) = SortMethod list
type Product = {code:int; price:float }
type Message<'a> = {id:int; body:'a}

type Name = 
    | Nickname of string 
    | FirstLast of string * string
type Tree<'a> = 
    | E 
    | T of Tree<'a> * 'a * Tree<'a>

[<EntryPoint>]
let main argv =
    let strategy() = 
        let s = Strategy(sort1)    
        s.Sort([1..6])

    strategy()




//usage
    let p = {code=123; price=9.99}
    let m = {id=1; body="hello"}

    let name = FirstLast("Piotr","op")
    printf "%A" p
    printf "%A" name
    Console.ReadKey()|>ignore
    printfn "Hello World from F#!"
    0 // return an integer exit code
