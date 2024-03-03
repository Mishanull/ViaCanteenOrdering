module JuiceTest


open NUnit.Framework
open Juice

[<TestFixture>]
type JuiceTests() =

    [<Test>]
    member this.``Orange Juice has base price of 7.0`` () =
        Assert.AreEqual(7.0, getJuiceTypeBasePrice OrangeJuice)

    [<Test>]
    member this.``Peach Juice has base price of 8.0`` () =
        Assert.AreEqual(8.0, getJuiceTypeBasePrice PeachJuice)

    [<Test>]
    member this.``Pomegranate Juice has base price of 8.3`` () =
        Assert.AreEqual(8.3, getJuiceTypeBasePrice PomegranateJuice)

    [<Test>]
    member this.``Tomato Juice has base price of 8.35`` () =
        Assert.AreEqual(8.35, getJuiceTypeBasePrice TomatoJuice)
