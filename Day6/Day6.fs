module Day6

let private findMarkerStart (input: string) boundary =
    (input
     |> Seq.toArray
     |> Array.mapi (fun index _ -> input[index .. index + boundary - 1] |> Seq.toArray)
     |> Array.findIndex (fun items -> (items |> Array.distinct |> Array.length) = boundary))
    + boundary

let solvePartOne input = findMarkerStart input 4
let solvePartTwo input = findMarkerStart input 14
