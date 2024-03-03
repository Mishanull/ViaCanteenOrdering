module Juice

type Juice = OrangeJuice | PeachJuice | PomegranateJuice | TomatoJuice
let getJuiceTypeBasePrice (juice: Juice) =
  match juice with
  | OrangeJuice -> 7.0
  | PeachJuice -> 8.0
  | PomegranateJuice -> 8.3
  | TomatoJuice -> 8.35