module CoreDomainTests.Food.SaladTest


open NUnit.Framework
open Salad

[<TestFixture>]
type SaladTests() =

    [<Test>]
    member this.``Price computation for Garden Salad`` () =
        let price = computeSaladPricePerBowl GardenSalad
        Assert.AreEqual(30, price)

    [<Test>]
    member this.``Price computation for Pasta Salad`` () =
        let price = computeSaladPricePerBowl PastaSalad
        Assert.AreEqual(30, price)

    [<Test>]
    member this.``Price computation for Tuna Salad`` () =
        let price = computeSaladPricePerBowl TunaSalad
        Assert.AreEqual(35, price)

    [<Test>]
    member this.``Price computation for Shrimp Cocktail`` () =
        let price = computeSaladPricePerBowl ShrimpCocktail
        Assert.AreEqual(45, price)
