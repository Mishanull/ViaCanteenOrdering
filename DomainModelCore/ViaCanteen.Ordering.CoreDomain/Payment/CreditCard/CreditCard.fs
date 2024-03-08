module CreditCard

open System
open Payment

type CreditCard(cardNumber: string, expiryDate: DateTime, amount: float) =
    member _.CardNumber = cardNumber
    member _.ExpiryDate = expiryDate
    member _.Amount = amount
    interface Payment with
        member _.ExecutePayment() =
            printfn "CreditCard Payment of %f processed for card %s" amount cardNumber
