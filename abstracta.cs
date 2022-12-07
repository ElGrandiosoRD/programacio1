using System;
abstract class F {
    private string x = "Ferreiras, Castro";
    private double y = 12.34E+12;
    private long z = 987364354;
    protected byte w = 34;

    public F(string x, double y, long z, byte w){
       //si se descomenta lo siguiente los datos pasados al constructor
       //reemplazan a los valores por defecto, que se les dio a las variables
       //al inicializarlas.
       /* this.x = x;
        this.y = y;
        this.z = z;
        this.w = w;*/
    }
    public string getx() {return x;}
    public double gety() {return y;}
    public long getz() {return z;}
    public abstract void verObjeto();
}
class G : F {
    public G(string x, double y, long z, byte w) : base(x, y, z, w){}
    
private int s = 9998833; //en el uml del mandato no habia ningun uso para esta variable.
public override void verObjeto(){
    Console.WriteLine("Valor de x: " + getx());
    Console.WriteLine("Valor de y: " + gety());
    Console.WriteLine("Valor de z: " + getz());
    Console.WriteLine("Valor de w: " + w);

}
}

class tester{
    static void Main(){
    G profe = new G("Camilo", 1234, 987, 2);
    
    profe.verObjeto();
    
    }      
}


