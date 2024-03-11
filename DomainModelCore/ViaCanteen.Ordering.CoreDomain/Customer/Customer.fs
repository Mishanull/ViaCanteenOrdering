module Customer

open System
open Drink
open Food
open Product
open Coffee

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
            if (drink.Type.Equals(Coffee)) then
              printfn
                $"Price is {(computeDrinkPrice (drink) + gtgVat (computeDrinkPrice (drink)) 24)
                            * float (qty)}"
            else
              printfn $"Price is {computeDrinkPrice (drink) * float (qty)}"
          | OrderFood(food, qty) -> printfn $"Price is {computeFullFoodPrice (food) * float (qty)}"
          | Comment(comment) -> printfn $"Comment: {comment}"
        PrintPriceForOrder message
        return! msgLoop
      }
    msgLoop)