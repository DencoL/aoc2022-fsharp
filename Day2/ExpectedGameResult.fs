module ExpectedGameResult

type ExpectedGameResult =
    | MyWin
    | MyLoss
    | Draw
with
    static member FromString input =
        match input with
        | "X" -> ExpectedGameResult.MyLoss
        | "Y" -> ExpectedGameResult.Draw
        | "Z" -> ExpectedGameResult.MyWin
        | _ -> failwith $"invalid expected game result type {input}"
