// #NoMono #NoMT #CodeGen #EmittedIL #NETFX20Only #NETFX40Only 
//
module StaticInit_Struct01
type C(s:System.DateTime) = 
  struct 
    static let x = "1".Length 
    static let f () = x + "2".Length
  end
