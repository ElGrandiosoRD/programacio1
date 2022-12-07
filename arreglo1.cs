using System;
/*
   arrObj1.cs
   csc.exe 3.5

  Ferreiras / C# /  Arreglo de objetos.

   En C#, los elementos de un arreglo pueden ser de tipos mezclados.
    
*/
//arrObj1.cs

class A {
    private double x;
    public A() {
          x = 0.001;     
    }
    public  A(double z) {
         x = z;
    }
    public void setX(double w){ x = w; }
    public  double getX() { return x; } 
    public static void verObjetos(object[ ] ao )  { // para ver los objetos en el arreglo
         // recorrer el arreglo con un foreach
         foreach (object   element   in   ao) {
              if (element != null) { // para evitar referencia nulas
                   Console.WriteLine(element.ToString()); 
        // ToString() Devuelve una cadena que representa al objeto actual.
	Console.WriteLine(element.GetType()); // retorna el tipo de dato almacenado en el elemento
	Console.WriteLine("----------");      
              }
         }
    }
} // fin clase A
//arrObj1.cs

// Tester-class

class  Tester {
     
    public static void Main()  {
         // declaracion y asignacion de memoria para un arreglo de objectos  tipo Object
        //   ( System.Object en el framework  .NET )

         Object[ ]   arrObj  = new Object[5]; // Recordar que de Object derivan todos los tipos en C#   
         // asignacion a cada elemento un objeto diferente
         arrObj[0] = new A( 98456 );
         arrObj[1] = 6.66;
         arrObj[2] = "Hola, arreglos de objetos en C#";
         arrObj[3]  = new object();
          // ver informacion de los objetos
         A.verObjetos(arrObj);
    }
   
}
