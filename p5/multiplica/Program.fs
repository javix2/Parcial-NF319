// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
let rec multi n1 n2 = if n1 = 0 ||n2 = 0 then 0 else n2 + multi (n1-1) n2

[<EntryPoint>]
let main argv = 
    
    printfn "------------EJERCICIO MULTIPLICA----------"
    let m = multi 4 8
    printfn "Resp: %d" m
    
    Console.ReadKey()|>ignore
    0 // return an integer exit code
