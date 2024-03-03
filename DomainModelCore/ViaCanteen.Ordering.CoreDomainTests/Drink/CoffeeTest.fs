module CoffeeTest 

open NUnit.Framework

open Coffee

[<TestFixture>]
type CoffeeTests() =

    [<Test>]
    member this.``Latte and Cappuccino have base price of 7.0`` () =
        Assert.AreEqual(7.0, getCoffeeTypeBasePrice Latte)
        Assert.AreEqual(7.0, getCoffeeTypeBasePrice Cappuccino)

    [<Test>]
    member this.``Strong and Espresso have base price of 6.5`` () =
        Assert.AreEqual(6.5, getCoffeeTypeBasePrice Strong)
        Assert.AreEqual(6.5, getCoffeeTypeBasePrice Espresso)

    [<Test>]
    member this.``Americano has base price of 6.0`` () =
        Assert.AreEqual(6.0, getCoffeeTypeBasePrice Americano)