module Payment
open MobilePay
open ViaCard
open CreditCard
type Payment = MobilePay of MobilePay
              | ViaCard of ViaCard
              | CreditCard of CreditCard