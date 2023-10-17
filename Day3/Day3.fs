module Day3

open System
open Common

let private getItemsPrioritySum items =
    let lowerPriorityBoundary = ('a' |> int) - 1
    let upperPriorityBoundary = ('A' |> int) - 27

    items
    |> Array.map (fun item ->
        let itemInt = item |> int

        match Char.IsAsciiLetterLower item with
        | true -> itemInt - lowerPriorityBoundary
        | false -> itemInt - upperPriorityBoundary)
    |> Array.sum

let solvePartOne (input: string) =
    input.Split "\n"
    |> Array.map (fun items -> items |> Seq.toArray)
    |> Array.collect (fun rucksack ->
        let halfSize = rucksack.Length / 2
        let firstHalf, secondHalf = rucksack |> Array.splitAt halfSize

        firstHalf
        |> Array.distinct
        |> Array.filter (fun firstHalfItem -> secondHalf |> Array.distinct |> Array.contains firstHalfItem))
    |> getItemsPrioritySum

let solvePartTwo (input: string) =
    input.Split "\n"
    |> Array.chunkBySize 3
    |> Array.map (fun groups -> groups |> Array.map (fun group -> group |> Seq.toArray))
    |> Array.collect (fun groups ->
        groups[0]
        |> Array.distinct
        |> Array.filter (fun firstGroupItem ->
            groups[1] |> Array.contains firstGroupItem
            && groups[2] |> Array.contains firstGroupItem))
    |> getItemsPrioritySum
