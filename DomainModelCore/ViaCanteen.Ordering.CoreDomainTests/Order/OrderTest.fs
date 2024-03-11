module OrderTests

open NUnit.Framework
open System
open Order
open Product
open Drink
open Coffee
open Food
open Bread
open Juice
[<TestFixture>]
type OrderTests() =
    [<Test>]
    member this.TestCreateOrder () =
        let order = createOrder
        Assert.IsNotNull(order)
        Assert.IsEmpty(order.Products)
        Assert.AreEqual(DateTime.Now.Date, order.OrderDate.Date)

    [<Test>]
    member this.TestAddDrink () =
        let initialOrder = Order.createOrder
        let drink: Drink =  {Size = Large; Type = DrinkType.Coffee(Cappuccino)  }
        let product: Product = Drink(drink);
        let updatedOrder = addProduct initialOrder product
        Assert.IsNotEmpty(updatedOrder.Products)
        Assert.AreEqual(1, List.length updatedOrder.Products)

    [<Test>]
    member this.TestComputeTotalPrice () =
        let initialOrder = createOrder
        let drink: Drink =  {Size = Large; Type = DrinkType.Coffee(Cappuccino)  }
        let product1: Product = Drink(drink)
        let bread: Bread = {Count = 2; Seeds = false; BreadType = White } 
        let food: Food = Bread(bread) 
        let product2 = Food(food)
        let updatedOrder = addProduct initialOrder product1 
        let finalOrder = addProduct updatedOrder product2 
        let totalPrice = computeTotalPrice finalOrder 
        Assert.AreEqual(16.5, totalPrice)
