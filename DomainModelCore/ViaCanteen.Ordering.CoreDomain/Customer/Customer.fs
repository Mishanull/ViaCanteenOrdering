module Customer

open System
open Drink
open Food
open Product
open Coffee
open Payment
open MobilePay
open CreditCard
open ViaCard
open IExecutePayment
type Customer = { Name: String; Id: Guid }

type OrderProductMsg =
  | OrderDrink of Drink * qty: int
  | OrderFood of Food * qty: int
  | Comment of string

let gtgVat amount percent = amount + (amount * percent / 100.0)

let gtgAgent =
  MailboxProcessor<OrderProductMsg>.Start(fun msg ->
    let rec msgLoop =
      async {
        let! message = msg.Receive()
        let order = Order.createOrder

        let PrintPriceForOrder message =
          match message with
          | OrderDrink(drink, qty) ->
            let product: Product = Drink drink
            let price = computeProductPrice product
            let orderWithProduct = Order.addProduct order product
            if (drink.Type.Equals(Coffee)) then
              printfn
                $"Total price is {( Order.computeTotalPrice orderWithProduct + gtgVat price 24) 
                            * float (qty)}"
              
            else
              printfn $"Price is {Order.computeTotalPrice orderWithProduct * float (qty)}"
          | OrderFood(food, qty) -> printfn $"Price is {computeBaseFoodPrice (food) * float (qty)}"
          | Comment(comment) -> printfn $"Comment: {comment}"
        PrintPriceForOrder message
        return! msgLoop
      }
    msgLoop)
  
let gtgPaymentAgent =
  MailboxProcessor<Payment>.Start(fun msg ->
    let rec msgLoop =
      async {
        let! message = msg.Receive()
        let rec printOrderPayment message =
          match message with
                | MobilePay mp -> (mp :> IExecutePayment).ExecutePayment()
                | ViaCard vc -> (vc :> IExecutePayment).ExecutePayment()
                | CreditCard cc -> (cc :> IExecutePayment).ExecutePayment()
        printfn $"{printOrderPayment message}"  
          
        return! msgLoop
      }
    msgLoop)
