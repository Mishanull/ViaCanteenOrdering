module DrinkTest

open NUnit.Framework
open Drink
open Coffee
open Juice
open Tea

[<TestFixture>]
type DrinkTests() =

    [<Test>]
    member this.``Price computation for small coffee`` () =
        let drink = { Type = { Coffee = Some(Coffee.Espresso); Juice = None; Tea = None }; Size = DrinkSize.Small }
        let expectedPrice = getCoffeeTypeBasePrice Coffee.Espresso + getCoffeeSizeAddition DrinkSize.Small
        Assert.AreEqual(expectedPrice, computePrice drink)

    [<Test>]
    member this.``Price computation for medium juice`` () =
        let drink = { Type = { Coffee = None; Juice = Some(Juice.OrangeJuice); Tea = None }; Size = DrinkSize.Medium }
        let expectedPrice = getJuiceTypeBasePrice Juice.OrangeJuice + getJuiceSizeAddition DrinkSize.Medium
        Assert.AreEqual(expectedPrice, computePrice drink)

    [<Test>]
    member this.``Price computation for large tea`` () =
        let drink = { Type = { Coffee = None; Juice = None; Tea = Some(Tea.GreenTea) }; Size = DrinkSize.Large }
        let expectedPrice = getTeaTypeBasePrice Tea.GreenTea + getTeaSizeAddition DrinkSize.Large
        Assert.AreEqual(expectedPrice, computePrice drink)