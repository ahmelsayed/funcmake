// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open MakeFunctionJson

[<EntryPoint>]
let main argv =
    let result =
        match argv.Length with
        | 2 -> if FunctionJsonConvert.TryConvert (argv.[0], argv.[1]) then "Conversion was successful" else "There was an error"
        | _ -> "USAGE: funcmake.exe <assemblyPath> <outputPath>"

    printfn "%s" result
    0