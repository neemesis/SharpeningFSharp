// Learn more about F# at http://fsharp.org

open System

type Season = {
    id: int;
    aid_date: DateTime;
    episode_count: int;
    poster_path: string;
    season_number: int;
}

type Status = Invoked = 0 | Started = 1 | Processing = 2 | Finished = 3
type CharStatus = Invoked = 'i' | Started = 's' | Processing = 'p' | Finished = 'f'

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    // records
    let season1 = { id = 1; aid_date = DateTime.Now; episode_count = 3; poster_path = "some/url"; season_number = 1 }
    printfn "%A" season1

    let { id = sId; season_number = seasonNo } = season1
    printfn "%A, %A" sId seasonNo

    printfn "%A, %A, %A" season1.id season1.episode_count season1.season_number

    // lists
    let emptyList = []
    printfn "%A" emptyList

    let fixedList = [2; 4; 6; 8; 10]
    printfn "%A" fixedList

    let listInit = List.init 8 (fun index -> index * 6)
    printfn "%A" listInit

    let rangeList = [20 .. 28]
    printfn "%A" rangeList

    let alphaList = ['x' .. 'z']
    printfn "%A" alphaList

    let yieldList = [ for x in 8 .. 12 do yield x * x * 2 ]
    printfn "%A" yieldList

    let consList = 1 :: rangeList
    printfn "%A" consList

    let consList2 = 1 :: 2 :: 3 :: rangeList
    printfn "%A" consList2

    let concatList = fixedList @ rangeList
    printfn "%A" concatList

    printfn "%A, %A, %A, %A, %A" concatList.Head concatList.IsEmpty concatList.Length concatList.Tail (concatList.Item 3)

    let reversedList = List.rev fixedList
    printfn "%A" reversedList

    let filteredList = concatList |> List.filter (fun x -> x % 3 = 1)
    printfn "%A" filteredList

    let mappedList = fixedList |> List.map (fun x -> ("V: " + (x / 2).ToString()))
    printfn "%A" mappedList

    // sequences
    let rangeSeq = seq { 20 .. 50 }
    printfn "%A" rangeSeq

    let skipSeq = seq { 50 .. -2 .. 20 }
    printfn "%A" skipSeq

    let funcSeq = seq { for x in 20 .. 30 do yield x * x / 2 }
    printfn "%A" funcSeq

    let elementSeq = Seq.item 8 funcSeq
    printfn "%A" elementSeq

    let appendSeq = Seq.append funcSeq funcSeq
    printfn "%A" appendSeq

    let distinctSeq = Seq.distinct (seq [5;5;5;5;6;6;6;6])
    printfn "%A" distinctSeq

    let mapSeq = Seq.map (fun x -> x + 2) (seq [1;2;3;4;5;6])
    printfn "%A" mapSeq

    // sets
    let fromEmptySet = Set.empty.Add(7).Add(3).Add(6).Add(1).Add(3)
    printfn "%A" fromEmptySet

    let fromListSet = Set.ofList [1 .. 10]
    printfn "%A" fromListSet

    let fromSeqSet = Set.ofSeq (seq { 1 .. 2 .. 10 })
    printfn "%A" fromSeqSet

    let diffSet = Set.difference fromListSet fromSeqSet
    printfn "%A" diffSet

    Set.iter (fun x -> printf "[%A]" x) diffSet

    printfn "\r\n"

    let isSubset = Set.isSubset diffSet fromListSet
    printfn "%A" isSubset

    let unionSet = fromListSet + fromSeqSet
    printfn "%A" unionSet

    // maps
    let fromEmptyMap = Map.empty.Add("Key1", 1).Add("Key2", 2)
    printfn "%A" fromEmptyMap

    let elementMap = fromEmptyMap.["Key1"]
    printfn "%A" elementMap

    let fromListMap = Map.ofList ([("A", 1); ("B", 2); ("C", 3);])
    printfn "%A" fromListMap

    // enums
    let invokedEnum = Status.Invoked
    let finishedCharEnum = CharStatus.Finished
    printfn "%A" invokedEnum
    printfn "%A" finishedCharEnum

    0 // return an integer exit code
