namespace Interoperability.FLibrary

// equivalent to a public static class
module ExportToCSharp =
    let exportedFunction x y =
        x * y

    let exportedFunctionWithTuple (x, y) = 
        x * y

    let exportedTuple1 = ("Do", "Re", "Mi")
    let exportedTuple2 = ("Do", "Re", "Mi")

    let refTuplesAreEqualInFSharp () =
        exportedTuple1 = exportedTuple2

    let structTuple1 = struct ("Fa", "So", "La")
    let structTuple2 = struct ("Fa", "So", "La")

    let structTuplesAreEqualInFSharp () = 
        structTuple1 = structTuple2

    let refAndStructTuplesAreEqualInFSharp () = 
        // this causes a compiler error
        // exportedTuple1 = structTuple1    
        false

    type public ExportedRecord =
        {
            FirstNote: string
            SecondNote: string
            ThirdNote: string
        }    

    let recordsComparison(r1: ExportedRecord, r2: ExportedRecord) = 
        r1 = r2

    type public ExportedUnion = 
    | SingleString of string
    | TwoStrings of string * string
    | TwoBools of bool * bool    

    let unionComparison(u1: ExportedUnion, u2: ExportedUnion) = 
        u1 = u2
