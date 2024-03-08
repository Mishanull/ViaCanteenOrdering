module Drink

open Coffee
open Tea
open Juice

type DrinkType =
  { Coffee: Coffee option
    Juice: Juice option
    Tea: Tea option }

type DrinkSize =
  | Small
  | Medium
  | Large

type Drink = { Type: DrinkType; Size: DrinkSize }

let getCoffeeSizeAddition (size: DrinkSize) =
  match size with
  | Small -> 1.0
  | Medium -> 2.0
  | Large -> 2.5

let getTeaSizeAddition (size: DrinkSize) =
  match size with
  | Small -> 0.5
  | Medium -> 0.75
  | Large -> 1.0

let getJuiceSizeAddition (size: DrinkSize) =
  match size with
  | Small -> 1.0
  | Medium -> 1.75
  | Large -> 2.5

let computePrice (drink: Drink) =
  match drink with
  | { Type = { Coffee = Some(coffee) }
      Size = size } -> getCoffeeTypeBasePrice (coffee) + getCoffeeSizeAddition (size)
  | { Type = { Juice = Some(juice) }
      Size = size } -> getJuiceTypeBasePrice (juice) + getJuiceSizeAddition (size)
  | { Type = { Tea = Some(tea) }
      Size = size } -> getTeaTypeBasePrice (tea) + getTeaSizeAddition (size)
  | _ -> failwith ("Invalid drink item.")
