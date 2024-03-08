module PaymentTest

open System
open Payment 
open ViaCard
open CreditCard
open MobilePay



// Test ViaCard
let testViaCard() =
    let (viaCard: Payment) = ViaCard("123456789", 100.0)
    viaCard.ExecutePayment()

// Test CreditCard
let testCreditCard() =
    let (creditCard : Payment) = CreditCard("987654321", DateTime(2024, 12, 31), 200.0)
    creditCard.ExecutePayment()

// Test MobilePay
let testMobilePay() =
    let (mobilePay: Payment) = MobilePay("555-1234", 150.0)
    mobilePay.ExecutePayment()

// Run all tests
let runTests() =
    testViaCard()
    testCreditCard()
    testMobilePay()

// Call this function to execute all tests
runTests()
