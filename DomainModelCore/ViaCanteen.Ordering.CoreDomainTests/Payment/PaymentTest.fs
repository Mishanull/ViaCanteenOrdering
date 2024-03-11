module PaymentTests

open NUnit.Framework
open System
open CreditCard
open MobilePay
open ViaCard
open Payment

// [<Test>]
// let ``Test CreditCard Payment Execution``() =
//     let payment = Payment.Payment
//     let creditCard = CreditCard("1234-5678-9101-1121", DateTime(2024, 12, 31), 100.0)
//     Assert.DoesNotThrow(fun () -> creditCard.Ex )
//
// [<Test>]
// let ``Test MobilePay Payment Execution``() =
//     let mobilePay = new MobilePay("0800123456", 50.0)
//     Assert.DoesNotThrow(fun () -> mobilePay)
//
// [<Test>]
// let ``Test ViaCard Payment Execution``() =
//     let viaCard = new ViaCard("1111-2222-3333-4444", 75.0)
//     Assert.DoesNotThrow(fun () -> viaCard.ExecutePayment())
