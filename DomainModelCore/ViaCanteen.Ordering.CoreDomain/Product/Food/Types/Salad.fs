module Salad

type Salad = GardenSalad | PastaSalad | TunaSalad | ShrimpCocktail

let computeSaladPricePerBowl salad =
  match salad with
  | GardenSalad | PastaSalad -> 30
  | TunaSalad -> 35
  | ShrimpCocktail -> 45