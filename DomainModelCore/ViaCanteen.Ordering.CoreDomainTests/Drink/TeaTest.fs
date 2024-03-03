module TeaTest

open NUnit.Framework
open Tea

[<TestFixture>]
type TeaTests() =

    [<Test>]
    member this.``Black Tea has base price of 6.0`` () =
        Assert.AreEqual(6.0, getTeaTypeBasePrice BlackTea)

    [<Test>]
    member this.``Green Tea has base price of 7.0`` () =
        Assert.AreEqual(7.0, getTeaTypeBasePrice GreenTea)

    [<Test>]
    member this.``Wild Berries Tea has base price of 8.5`` () =
        Assert.AreEqual(8.5, getTeaTypeBasePrice WildBerriesTea)