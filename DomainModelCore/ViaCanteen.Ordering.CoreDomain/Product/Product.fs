module ViaCanteen.Ordering.CoreDomain.Product

open Drink
open Food

type Product = { Drink: Drink option; Food: Food option }

let computeProductPrice product =
  match product with
  | {Drink= Some(drink); Food = None} -> computePrice(drink)
  | {Drink= None; Food = Some(food)} -> computeFullFoodPrice(food)
  | _ -> failwith "Misconfiguration in product."