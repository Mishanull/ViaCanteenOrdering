module ViaCanteen.Ordering.CoreDomain.Product

open Drink
open Food

type Product = { Drink: Drink option; Food: Food option }