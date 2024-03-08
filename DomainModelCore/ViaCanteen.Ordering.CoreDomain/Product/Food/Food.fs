module Food

open Bread
open Salad
open WarmFood
open Dessert

type Food =
  { Bread: Bread option
    Dessert: Dessert option
    Salad: Salad option
    WarmFood: WarmFood option
    ExtraTax: float option }

let computeBaseFoodPrice food =
  match food with
  | { Bread = Some(bread) } -> computeBreadPrice (bread)
  | { Dessert = Some(dessert) } -> computeDessertPrice (dessert)
  | { Salad = Some(salad) } -> computeSaladPricePerBowl (salad)
  | { WarmFood = Some(warmFood) } -> computeWarmFoodPrice (warmFood)
  | _ -> failwith ("Invalid food item.")

let computeFullFoodPrice food =
  let price = computeBaseFoodPrice (food)

  if (food.ExtraTax.IsNone) then
    price
  else
    price + price * (food.ExtraTax.Value / 100.0)