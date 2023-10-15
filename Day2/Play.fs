module Play

type Play =
    | Rock
    | Paper
    | Scissors
with
    member this.Beats =
        match this with
        | Rock -> Play.Scissors
        | Paper -> Play.Rock
        | Scissors -> Play.Paper

    member this.CanBeat play =
        this.Beats = play

    member this.IsDrawTo otherPlay =
        this = otherPlay

    member this.LosesTo =
        match this with
        | Rock -> Play.Paper
        | Paper -> Play.Scissors
        | Scissors -> Play.Rock

    member this.GetScore =
        match this with
        | Rock -> 1
        | Paper -> 2
        | Scissors -> 3

    static member FromString input =
        match input with
        | "A" | "X" -> Play.Rock
        | "B" | "Y" -> Play.Paper
        | "C" | "Z" -> Play.Scissors
        | _ -> failwith $"invalid play type {input}"
