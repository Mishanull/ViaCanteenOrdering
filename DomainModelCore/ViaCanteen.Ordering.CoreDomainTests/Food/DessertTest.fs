module DessertTest


open NUnit.Framework
open Dessert

[<TestFixture>]
type DessertTests() =

    [<Test>]
    member this.``Price computation for Dessert priced by weight`` () =
        let dessert = { WeightInGrams = Some(200.0); Count = None; PricePerUnit = 0.5 }
        let expectedPrice = 0.5 * (200.0 / 100.0)
        Assert.AreEqual(expectedPrice, computeDessertPrice dessert)

    [<Test>]
    member this.``Price computation for Dessert priced by count`` () =
        let dessert = { WeightInGrams = None; Count = Some(3); PricePerUnit = 2.0 }
        let expectedPrice = 2.0 * float (3)
        Assert.AreEqual(expectedPrice, computeDessertPrice dessert)
