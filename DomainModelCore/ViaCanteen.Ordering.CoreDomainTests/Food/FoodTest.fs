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
        let food = Bread bread 
        let expectedPrice = computeBreadPrice bread
        Assert.AreEqual(expectedPrice, computeBaseFoodPrice food)

    [<Test>]
    member this.``Base price computation for Salad`` () =
        let salad = Salad.GardenSalad
        let food = Salad salad 
        let expectedPrice = Salad.computeSaladPricePerBowl salad
        Assert.AreEqual(expectedPrice, computeBaseFoodPrice food)

    [<Test>]
    member this.``Base price computation for Warm Food`` () =
        let warmFood = { WarmFood.WeightInGrams = 300.0; PriceMeasurementBase = 100.0; Price = 5.0 }
        let food = WarmFood warmFood; 
        let expectedPrice = WarmFood.computeWarmFoodPrice warmFood
        Assert.AreEqual(expectedPrice, computeBaseFoodPrice food)

