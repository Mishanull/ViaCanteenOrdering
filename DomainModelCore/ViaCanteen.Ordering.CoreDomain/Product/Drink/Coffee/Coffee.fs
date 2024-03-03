module Coffee

type Coffee = Latte | Cappuccino | Strong | Americano | Espresso
let getCoffeeTypeBasePrice coffee =
  match coffee with
  | Latte | Cappuccino -> 7.0
  | Strong | Espresso -> 6.5
  | Americano -> 6.0
  