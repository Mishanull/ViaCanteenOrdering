module CoreDomainTests.Food.FoodTest


open Bread
open Dessert
open WarmFood
open NUnit.Framework
open Food

[<TestFixture>]
type FoodTests() =

    [<Test>]
    member this.``Base price computation for Bread`` () =
        let bread = { Bread.Count = 2; BreadType = BreadType.White; Seeds = false }
        let food = { Bread = Some(bread); Dessert = None; Salad = None; WarmFood = None; ExtraTax = None }
        let expectedPrice = Bread.computeBreadPrice bread
        Assert.AreEqual(expectedPrice, computeBaseFoodPrice food)

    [<Test>]
    member this.``Full price computation for Dessert with Extra Tax`` () =
        let dessert = { Dessert.WeightInGrams = Some(200.0); Count = None; PricePerUnit = 1.0 }
        let food = { Bread = None; Dessert = Some(dessert); Salad = None; WarmFood = None; ExtraTax = Some(10.0) }
        let basePrice = Dessert.computeDessertPrice dessert
        let expectedFullPrice = basePrice + basePrice * 0.1
        Assert.AreEqual(expectedFullPrice, computeFullFoodPrice food)

    [<Test>]
    member this.``Base price computation for Salad`` () =
        let salad = Salad.GardenSalad
        let food = { Bread = None; Dessert = None; Salad = Some(salad); WarmFood = None; ExtraTax = None }
        let expectedPrice = Salad.computeSaladPricePerBowl salad
        Assert.AreEqual(expectedPrice, computeBaseFoodPrice food)

    [<Test>]
    member this.``Base price computation for Warm Food`` () =
        let warmFood = { WarmFood.WeightInGrams = 300.0; PriceMeasurementBase = 100.0; Price = 5.0 }
        let food = { Bread = None; Dessert = None; Salad = None; WarmFood = Some(warmFood); ExtraTax = None }
        let expectedPrice = WarmFood.computeWarmFoodPrice warmFood
        Assert.AreEqual(expectedPrice, computeBaseFoodPrice food)

    [<Test>]
    member this.``Full price computation without Extra Tax`` () =
        let warmFood  = { WarmFood.WeightInGrams = 150.0; PriceMeasurementBase = 100.0; Price = 25.0 }
        let food = { Bread = None; Dessert = None; Salad = None; WarmFood = Some(warmFood); ExtraTax = None }
        let expectedPrice = WarmFood.computeWarmFoodPrice warmFood
        Assert.AreEqual(expectedPrice, computeFullFoodPrice food)
