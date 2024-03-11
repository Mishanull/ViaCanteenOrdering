module Food

open Bread
open Salad
open WarmFood
open Dessert

type Food =
  | Bread of Bread
  | Dessert of Dessert
  | Salad of Salad
  | WarmFood of WarmFood

let computeBaseFoodPrice food =
  match food with
  | Bread bread -> computeBreadPrice (bread)
  | Dessert dessert -> computeDessertPrice (dessert)
  | Salad salad -> computeSaladPricePerBowl (salad)
  | WarmFood warmFood -> computeWarmFoodPrice (warmFood)

let computeFullFoodPrice food = computeBaseFoodPrice (food)