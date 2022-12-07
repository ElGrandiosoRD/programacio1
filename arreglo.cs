using System;
/*
  arrObj0.cs
  csc.ee  3.5

  C# / Ferreiras / POO /  Arreglos de objetos

*/
//  arrObj0.cs

class A {

    private double x;

    public A() {
          x = 0.001; 
         Console.WriteLine( "\nUn objeto por defecto creado");
    }

    public  A(double z) {
         x = z;
         Console.WriteLine("\nObjeto construido con un argumento");
    }

    public void setX(double w){ x = w; }
    public  double getX() { return x; } 

     public static void verArreglo( A [ ]  a ) { // para invocarla solo con el nombre de la clase A
          Console.WriteLine("\nEl estado de los objetos es:\n");
              for( int  i= 0; i < a.Length; ++i)
                   Console.WriteLine( a[i].getX() );
    }
}
//  arrObj0.cs

// Tester-class

class Tester {

     public static void Main() {
         // declarar un arreglo de objetos  tipo A 
         A [ ]  a = new A[5];  // arreglo de 5 objetos tipo A
         // Poblar el arreglo con valores por defecto  
         for( int  i= 0; i < 5; ++i) {
              a[i] = new A();
         }       
         A.verArreglo(a);
         // Cambiamos el estado de los objetos  
         for(int i = 0;  i < 5; ++i) 
              a[i].setX(1.23 + i);
         // Mostrar el contenido actual del arreglo
         A.verArreglo(a);
         // Usando el constructor con argumento, en un nuevo  de objetos A
         A[ ] b = {  new A(12.34), new A(4.56), new A(7.66) }; //  declaración e inicialización del arreglo con objetos A
         // mostrar el estado de los elementos del arreglo
         for ( int i = 0;  i < b.Length; ++i)
              Console.WriteLine( b[i].getX() );
         b[1] = new A(5.55); // Accedemos directamente al 2do. elemento y cambiamos su estado
         Console.WriteLine("\nEstado de este objeto = " +  b[1].getX()  ); 
    }
} 
