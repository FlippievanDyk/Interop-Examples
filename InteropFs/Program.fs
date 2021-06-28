open System.Runtime.InteropServices
type Point = struct 
  val x: int 
  val y: int
  new (x, y) =
    {x = x ; y = y}
end

module Interop =
  
  [<DllImport(@"/mnt/c/Users/Flippie/Documents/GIT/test/Interop/c_linux/a.out", CallingConvention = CallingConvention.Cdecl)>]
  extern int one()
  
  [<DllImport(@"/mnt/c/Users/Flippie/Documents/GIT/test/Interop/c_linux/a.out", CallingConvention = CallingConvention.Cdecl)>]
  extern int addOne(int)  
  
  [<DllImport(@"/mnt/c/Users/Flippie/Documents/GIT/test/Interop/c_linux/a.out", CallingConvention = CallingConvention.Cdecl)>]
  extern int addTwo(int)  
  
  [<DllImport(@"/mnt/c/Users/Flippie/Documents/GIT/test/Interop/c_linux/a.out", CallingConvention = CallingConvention.Cdecl)>]
  extern void HelloWorld()
  
  [<DllImport(@"/mnt/c/Users/Flippie/Documents/GIT/test/Interop/c_linux/a.out", CallingConvention = CallingConvention.Cdecl)>]
  extern Point makePoint (int  a, int  b) 

  [<DllImport(@"/mnt/c/Users/Flippie/Documents/GIT/test/Interop/c_linux/a.out", CallingConvention = CallingConvention.Cdecl)>]
  extern int SumPoint (Point) 




[<EntryPoint>]
let main _ =
  Interop.addTwo (10) |> printfn "Twelve: %A"
  
  //Make and pass structure: pretty print not default, which is unfortunate.
  let a = Interop.makePoint (1 , 2)
  printf "point %A\n" a
  printf "point x co-ordinate %O\n" a.x
  printf "point y co-ordinate %O\n" a.y
  Interop.SumPoint(a) |> printf "Sum of created point: %A\n" 

  Interop.HelloWorld()
  let x = System.Console.ReadLine()
  
  
  0