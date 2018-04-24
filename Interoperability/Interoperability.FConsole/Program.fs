// Learn more about F# at http://fsharp.org

open System
open Interoperability.CLibrary
open System

[<EntryPoint>]
let main argv =
    let library = new ExportToFSharp()
    // F# float is double in C#
    library.SomeNumber <- 42.0f
    library.SomeNumber |> printfn "%f"

    let notes = library.NotesInTheScale()
    notes 
    |> Seq.iter (printfn "%s") 

    let printFunc n =
        sprintf "You passed in the number %i" n

    let delegateResult = library.UseDelegate(Func<int, string>(printFunc), 3)
    delegateResult |> printfn "%s" 

    let objectExpression = 
        {
            new IExportToFSharp
                with
                    member this.SayHello() = "Hello from object expression."
                    member this.SayGoodbye() = "Goodbye from object expression."
        }

    objectExpression.SayHello() |> printfn "%s"
    objectExpression.SayGoodbye() |> printfn "%s"

    0 // return an integer exit code
