module Product

open Drink
open Food

type Product =
    | Drink of Drink
    | Food of Food

let computeProductPrice product =
  match product with
  | Drink drink -> computeDrinkPrice(drink)
  | Food food -> computeBaseFoodPrice(food)