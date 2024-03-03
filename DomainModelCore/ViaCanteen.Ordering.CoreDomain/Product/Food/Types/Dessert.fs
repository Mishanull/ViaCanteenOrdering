module Dessert

type Dessert =
  { WeightInGrams: float option
    Count: int option
    PricePerUnit: float }

let computeDessertPrice (dessert: Dessert) =
  match dessert with
  | { WeightInGrams = Some(weight)
      Count = None
      PricePerUnit = price } -> price * (weight / 100.0)
  | { WeightInGrams = None
      Count = Some(count)
      PricePerUnit = price } -> price * float (count)
  | _ -> failwith ("Misconfiguration in dessert.")
