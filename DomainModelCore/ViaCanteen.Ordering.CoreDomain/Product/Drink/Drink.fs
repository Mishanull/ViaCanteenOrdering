module ViaCanteen.Ordering.CoreDomain.Product

type DrinkType = Coffee | Tea | Juice | Soda
type DrinkSize = Small | Medium | Large
type Drink = {Type: DrinkType; Size: DrinkSize}

let computePrice (drink: Drink) =
  match drink with
  | {Type = Coffee; Size = Small}-> 7