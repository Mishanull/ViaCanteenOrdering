module Bread

type BreadType = Black | White 
type Bread = { Count: int; BreadType: BreadType; Seeds: bool }

let computeBreadPrice (bread: Bread) =
  match bread with
  | {Count = count; BreadType = White; Seeds = false } -> 3.5 * float(count)
  | {Count = count; BreadType = Black; Seeds = false } | {Count = count; BreadType = White; Seeds = true} -> 4.0 * float(count)
  | {Count = count; BreadType = Black; Seeds = true } -> 4.5 * float(count)