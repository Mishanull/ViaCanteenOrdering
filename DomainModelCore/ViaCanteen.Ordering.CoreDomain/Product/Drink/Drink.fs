module Drink

open Coffee
open Tea
open Juice

type DrinkType =
     | Coffee of Coffee
     | Juice of Juice
     | Tea of Tea

type DrinkSize =
  | Small
  | Medium
  | Large

type Drink = { Type: DrinkType; Size: DrinkSize }

let getCoffeeSizeAddition (size: DrinkSize) =
  match size with
  | Small -> 1.0
  | Medium -> 2.0
  | Large -> 2.5

let getTeaSizeAddition (size: DrinkSize) =
  match size with
  | Small -> 0.5
  | Medium -> 0.75
  | Large -> 1.0

let getJuiceSizeAddition (size: DrinkSize) =
  match size with
  | Small -> 1.0
  | Medium -> 1.75
  | Large -> 2.5

let computeDrinkPrice (drink: Drink) =
  match drink with
  | { Type = Coffee coffee 
      Size = size } -> getCoffeeTypeBasePrice (coffee) + getCoffeeSizeAddition (size)
  | { Type =  Juice juice
      Size = size } -> getJuiceTypeBasePrice (juice) + getJuiceSizeAddition (size)
  | { Type = Tea tea
      Size = size } -> getTeaTypeBasePrice (tea) + getTeaSizeAddition (size)
