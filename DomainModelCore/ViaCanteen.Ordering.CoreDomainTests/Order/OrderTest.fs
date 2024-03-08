module OrderTests

open NUnit.Framework
open System
open Order
open Product

[<TestFixture>]
type OrderTests() =
    // Set up for tests
    [<SetUp>]
    member this.Setup () =


    // Test for creating a new order
    [<Test>]
    member this.TestCreateOrder () =
        let order = Order.createOrder()
        Assert.IsNotNull(order)
        Assert.IsEmpty(order.Products)
        Assert.AreEqual(DateTime.Now.Date, order.OrderDate.Date)

    // Test for adding a product to an order
    [<Test>]
    member this.TestAddProduct () =
        let initialOrder = Order.createOrder()
        let product = { Name = "Test Product"; Price = 10.0 }
        let updatedOrder = Order.addProduct initialOrder product
        Assert.IsNotEmpty(updatedOrder.Products)
        Assert.AreEqual(1, List.length updatedOrder.Products)

    // Test for computing the total price of an order
    [<Test>]
    member this.TestComputeTotalPrice () =
        let initialOrder = Order.createOrder()
        let product1 = { Name = "Test Product 1"; Price = 10.0 }
        let product2 = { Name = "Test Product 2"; Price = 20.0 }
        let orderWithProducts = initialOrder |> Order.addProduct product1 |> Order.addProduct product2
        let totalPrice = Order.computeTotalPrice orderWithProducts
        Assert.AreEqual(30.0, totalPrice)
