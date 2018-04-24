using System;
using Interoperability.FLibrary;

namespace Interoperability.CConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoParamsResult = ExportToCSharp.exportedFunction(6, 7);
            Console.WriteLine($"The result of 6 times 7 is {twoParamsResult}");

            var tupleResult = ExportToCSharp.exportedFunctionWithTuple(6, 7);
            Console.WriteLine($"The result of 6 times 7 is {twoParamsResult}");

            // partial functions are not supported in C#
            // var partialFunction = ExportToCSharp.exportedFunction(6);

            var refc = RefTuplesAreEqualInCSharp();
            var reff = ExportToCSharp.refTuplesAreEqualInFSharp();
            Console.WriteLine($"Ref tuples: {ExportToCSharp.exportedTuple1} and {ExportToCSharp.exportedTuple2}");
            Console.WriteLine($"Comparing ref tuples in C Sharp {refc} and FSharp {reff}.");

            var cSharpTuple = new Tuple<string, string, string>("Do", "Re", "Mi");
            Console.WriteLine(
                $"Ref & C# tuple {ExportToCSharp.exportedTuple1} = {cSharpTuple}: {ExportToCSharp.exportedTuple1 == cSharpTuple}");

            Console.WriteLine($"Value/Struct tuples cannot be compared in C#, although they are visible.");
            Console.WriteLine($"Struct tuples: {ExportToCSharp.structTuple1} and {ExportToCSharp.structTuple2}");

            var structf = ExportToCSharp.structTuplesAreEqualInFSharp();
            Console.WriteLine($"But they can be compared in F# and the result is {structf}");
            Console.WriteLine("However, neither of the languages can compare a reference and struct tuple.");

            Console.WriteLine("Ref tuples are immutable, but value tuples are mutable.");
            var refTuple = ExportToCSharp.exportedTuple1;
            //refTuple.Item1 = "NewValue";
            var valTuple = ExportToCSharp.structTuple1;
            valTuple.Item1 = "NewValue";
            Console.WriteLine($"Tuples after mutation {refTuple} and {valTuple}");

            // In general, tuples behave differently in F# and C# and should not be used in interoperability.

            var rec1 = new ExportToCSharp.ExportedRecord("Ti", "So", "Re");
            var rec2 = new ExportToCSharp.ExportedRecord("Ti", "So", "Re");

            Console.WriteLine($"Are records {rec1} and {rec2} equal?");
            Console.WriteLine($"In C#: {rec1 == rec2}");
            Console.WriteLine($"In F#: {ExportToCSharp.recordsComparison(rec1, rec2)}");

            // However, they are still immutable in C# as well
            // rec1.FirstNote = "ChangedValue";

            var union1 = ExportToCSharp.ExportedUnion.NewSingleString("Ti");
            var union2 = ExportToCSharp.ExportedUnion.NewSingleString("Ti");

            Console.WriteLine($"Are unions {union1} and {union2} equal?");
            Console.WriteLine($"In C#: {union1 == union2}");
            Console.WriteLine($"In F#: {ExportToCSharp.unionComparison(union1, union2)}");

            // We can change the type of the exported union
            union2 = ExportToCSharp.ExportedUnion.NewTwoBools(true, false);

            Console.WriteLine($"Are unions {union1} and {union2} equal?");
            Console.WriteLine($"In C#: {union1 == union2}");
            Console.WriteLine($"In F#: {ExportToCSharp.unionComparison(union1, union2)}");

            var u2v1 = (union2 as ExportToCSharp.ExportedUnion.TwoBools).Item1;
            var u2v2 = (union2 as ExportToCSharp.ExportedUnion.TwoBools).Item2;

            Console.WriteLine($"Union values are {u2v1} and {u2v2}");
        }

        private static bool RefTuplesAreEqualInCSharp()
        {
            return ExportToCSharp.exportedTuple1 == ExportToCSharp.exportedTuple2;
        }

        // private static bool StructTuplesAreEqualInCSharp()
        // {
        //     return ExportToCSharp.structTuple1 == ExportToCSharp.structTuple2;
        // }

        // private static bool RefAndStructTuplesAreEqualInCSharp()
        // {
        //     return ExportToCSharp.exportedTuple1 == ExportToCSharp.structTuple2;
        // }
    }
}
