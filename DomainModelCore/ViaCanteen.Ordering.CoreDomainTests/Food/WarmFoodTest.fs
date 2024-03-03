module CoreDomainTests.Food.WarmFoodTest


open NUnit.Framework
open WarmFood

[<TestFixture>]
type WarmFoodTests() =

    [<Test>]
    member this.``Price computation for Warm Food with base matching weight`` () =
        let warmFood = { WeightInGrams = 100.0; PriceMeasurementBase = 100.0; Price = 5.0 }
        let expectedPrice = 5.0  // Price should match directly since weight matches the base
        Assert.AreEqual(expectedPrice, computeWarmFoodPrice warmFood)

    [<Test>]
    member this.``Price computation for Warm Food with double the base weight`` () =
        let warmFood = { WeightInGrams = 200.0; PriceMeasurementBase = 100.0; Price = 5.0 }
        let expectedPrice = 10.0  // Price doubles since the weight is double the base
        Assert.AreEqual(expectedPrice, computeWarmFoodPrice warmFood)

    [<Test>]
    member this.``Price computation for Warm Food with half the base weight`` () =
        let warmFood = { WeightInGrams = 50.0; PriceMeasurementBase = 100.0; Price = 5.0 }
        let expectedPrice = 2.5  // Price halves since the weight is half the base
        Assert.AreEqual(expectedPrice, computeWarmFoodPrice warmFood)

    [<Test>]
    member this.``Price computation for Warm Food with specific weight and base`` () =
        let warmFood = { WeightInGrams = 150.0; PriceMeasurementBase = 100.0; Price = 5.0 }
        let expectedPrice = 7.5  // Custom calculation based on the specific weight and base
        Assert.AreEqual(expectedPrice, computeWarmFoodPrice warmFood)
