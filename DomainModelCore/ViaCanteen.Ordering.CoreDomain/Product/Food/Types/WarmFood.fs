module WarmFood

type WarmFood = {
                 WeightInGrams: float
                 PriceMeasurementBase: float
                 Price: float
                 }

let computeWarmFoodPrice warmFood =
  match warmFood with
  | {WeightInGrams = weight; PriceMeasurementBase = priceBase; Price = price} -> price * (weight/priceBase)