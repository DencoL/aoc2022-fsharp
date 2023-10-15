module Day2

open Common
open Play
open ExpectedGameResult

let private playGame (input: string) (myPlayFunc: string -> Play -> Play) =
    input.Split("\n")
    |> Array.map (fun line ->
        let plays = Helpers.split line " "
        let elfPlay = Play.FromString plays[0]
        let myPlay = myPlayFunc plays[1] elfPlay

        let mutable myTotalScore = myPlay.GetScore

        if elfPlay.IsDrawTo myPlay then
            myTotalScore <- myTotalScore + 3

        if myPlay.CanBeat elfPlay then
            myTotalScore <- myTotalScore + 6

        myTotalScore)
    |> Array.sum

let solvePartOne input =
    playGame input (fun playIdentifier _ -> Play.FromString playIdentifier)

let solvePartTwo input =
    playGame input (fun expectedGameResultIdentifier elfPlay ->
        match ExpectedGameResult.FromString(expectedGameResultIdentifier) with
        | ExpectedGameResult.MyLoss -> elfPlay.Beats
        | ExpectedGameResult.Draw -> elfPlay
        | ExpectedGameResult.MyWin -> elfPlay.LosesTo)
