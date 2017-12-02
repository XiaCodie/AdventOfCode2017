// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv =
    let input = argv |> Array.head
    let numbers =
        input
        |> Array.filter (fun x -> )
    printfn "%A" argv
    0 // return an integer exit code
