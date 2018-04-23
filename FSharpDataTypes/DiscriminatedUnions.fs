namespace DataTypes

open System
module DiscriminatedUnions = 

    // 3 discriminated unions
    // like enums, but each case can have different data
    type TrafficSignals = 
    | Red
    | Yellow
    | Green

    type Shape = 
    | Circle of float
    | Rectangle of float * float
    | Square of float

    type MessageReceiverState = 
    | Off
    | Activating of WhenActivated : DateTime
    | Idle of IdleDuration : TimeSpan
    | MessageReceived of Message : string * WhenReceived : DateTime
    | Deactivating of WhenDeactivated : DateTime