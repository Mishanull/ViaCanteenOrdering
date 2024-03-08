module ViaCard
open IExecutePayment
type ViaCard(cardNumber: string, amount: float) =
    member _.CardNumber = cardNumber
    member _.Amount = amount
    
    
    interface IExecutePayment with
        member _.ExecutePayment() =
            printfn "ViaCard Payment of %f processed for card %s" amount cardNumber