module MobilePay

open Payment

type MobilePay(phoneNumber: string, amount: float) =
  member _.PhoneNumber = phoneNumber
  member _.Amount = amount

  member _.ExecutePayment() =
    printfn "MobilePay Payment of %f processed for phone %s" amount phoneNumber