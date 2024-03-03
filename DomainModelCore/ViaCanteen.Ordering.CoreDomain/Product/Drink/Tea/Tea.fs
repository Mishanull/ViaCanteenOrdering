module Tea

type Tea = BlackTea | GreenTea | WildBerriesTea
let getTeaTypeBasePrice (tea: Tea) =
  match tea with
  | BlackTea -> 6.0
  | GreenTea -> 7.0
  | WildBerriesTea -> 8.5