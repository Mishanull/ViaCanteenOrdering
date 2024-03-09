module ViaCard

open Payment

type ViaCard(cardNumber: string, amount: float) =
    member _.CardNumber = cardNumber
    member _.Amount = amount
    interface Payment with
        member _.ExecutePayment() =
            printfn "ViaCard Payment of %f processed for card %s" amount cardNumber