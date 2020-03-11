module Sentry

open Fable.Core

type Dsn = {
    dsn : string
}

type ISentry =
    abstract init : Dsn -> unit

[<ImportAll("@sentry/browser")>]
let Sentry : ISentry = jsNative

[<Emit("sentryUrl")>]
let sentryUrl : string = jsNative

let init () =
    Sentry.init {
        dsn = sentryUrl
    }