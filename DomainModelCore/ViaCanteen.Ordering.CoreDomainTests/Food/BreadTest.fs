module BreadTest

open NUnit.Framework
open Bread

[<TestFixture>]
type BreadTests() =

    [<Test>]
    member this.``Price computation for White Bread without Seeds`` () =
        let bread = { Count = 1; BreadType = White; Seeds = false }
        let expectedPrice = 3.5
        Assert.AreEqual(expectedPrice, computeBreadPrice bread)

    [<Test>]
    member this.``Price computation for Black Bread without Seeds`` () =
        let bread = { Count = 1; BreadType = Black; Seeds = false }
        let expectedPrice = 4.0
        Assert.AreEqual(expectedPrice, computeBreadPrice bread)

    [<Test>]
    member this.``Price computation for White Bread with Seeds`` () =
        let bread = { Count = 1; BreadType = White; Seeds = true }
        let expectedPrice = 4.0
        Assert.AreEqual(expectedPrice, computeBreadPrice bread)

    [<Test>]
    member this.``Price computation for Black Bread with Seeds`` () =
        let bread = { Count = 1; BreadType = Black; Seeds = true }
        let expectedPrice = 4.5
        Assert.AreEqual(expectedPrice, computeBreadPrice bread)

    [<Test>]
    member this.``Price computation for multiple White Breads without Seeds`` () =
        let bread = { Count = 2; BreadType = White; Seeds = false }
        let expectedPrice = 3.5 * 2.0
        Assert.AreEqual(expectedPrice, computeBreadPrice bread)
