module DrinkTest

open System
open NUnit.Framework
open Drink
open Coffee
open Juice
open Tea

[<TestFixture>]
type DrinkTests() =

    [<Test>]
    member this.``Price computation for small coffee`` () =
       
        let drink = {Type = DrinkType.Coffee(Cappuccino); Size = Small} 
        let expectedPrice = getCoffeeTypeBasePrice Cappuccino + getCoffeeSizeAddition DrinkSize.Small
        Assert.AreEqual(expectedPrice, computeDrinkPrice drink)

    [<Test>]
    member this.``Price computation for medium juice`` () =
        let drink = { Type = DrinkType.Juice(OrangeJuice); Size = DrinkSize.Medium }
        let expectedPrice = getJuiceTypeBasePrice OrangeJuice + getJuiceSizeAddition DrinkSize.Medium
        Assert.AreEqual(expectedPrice, computeDrinkPrice drink)

    [<Test>]
    member this.``Price computation for large tea`` () =
        let drink = { Type = DrinkType.Tea(GreenTea); Size = DrinkSize.Large }
        let expectedPrice = getTeaTypeBasePrice GreenTea + getTeaSizeAddition DrinkSize.Large
        Assert.AreEqual(expectedPrice, computeDrinkPrice drink)