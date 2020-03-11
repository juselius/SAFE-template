module Settings

open System.IO
open Thoth.Json.Net

type Settings = {
    seqUrl : string
    seqApiKey : string
}

let settings =
    let settings = File.ReadAllText "appsettings.json"
    match Decode.Auto.fromString<Settings> (settings, CamelCase) with
    | Ok s -> s
    | Error e -> failwith e

