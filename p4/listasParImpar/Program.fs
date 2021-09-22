// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
[<EntryPoint>]
let main argv = 
    //printfn "%A" argv

    printfn "------------EJERCICIO LISTAS----------"
    let lista = [1..10]
    let lpares = List.filter(fun n-> (n % 2) = 0 )lista 
    let limpares = List.filter(fun n-> (n % 2) = 1 )lista
    
    printfn "%A" lista
    printfn "%A pares " lpares 
    printfn "%A impares " limpares
    
    Console.ReadKey() |>ignore
    0 // return an integer exit code
