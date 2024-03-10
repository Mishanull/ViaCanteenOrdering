module Order

open Product
open System

type Order = {
    Id: Guid
    Products: Product list
    OrderDate: DateTime
}

let createOrder () = {
    Id = Guid.NewGuid()
    Products = []
    OrderDate = DateTime.Now
}

let addProduct (order: Order) (product: Product) =
    { order with Products = product :: order.Products }

let computeTotalPrice (order: Order) =
    order.Products |> List.fold (fun acc prod -> acc + Product.computeProductPrice prod) 0.0
