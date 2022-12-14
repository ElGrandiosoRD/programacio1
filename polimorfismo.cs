using System;

abstract class Animal{
    protected int legs;//variable    
    protected Animal(int legs) { this.legs = legs; }//constructor
    //metodos
    public virtual void walk() { Console.WriteLine("El animal esta caminando."); }
    public abstract void eat();
}//fin de clase animal.
interface IPet{
    string getName();
    void setName(string n);
    void play(); 
}//fin de interface IPet.
class spider: Animal{

    public spider(): base(8){}//constructor
    //public override void walk(){Console.WriteLine("La araña esta caminando, con sus " + legs + " patas.");}
    public override void eat (){ Console.WriteLine("La araña se come un mosquito."); }//metodo

}//fin de la clase spider.
class cat: Animal, IPet{
    private string name;//variable

    //constructores
    public cat(string n): base(4) { name = n; }
    public cat(): base(4){}

    //metodos
    public string getName() { return name; }
    public void setName(string n) { name = n; }
    public void play() { Console.WriteLine("El gato " + getName() + " juega con un raton."); }
    public override void eat() { Console.WriteLine(getName() + " esta comiendose el raton."); }
}//fin de la clase cat.
class fish: Animal, IPet{
    private string name;
    public fish(): base(0){}

    //metodos
    public string getName() { return name; }
    public void setName(string n) { name = n; }
    public void play() { Console.WriteLine("El pez " + getName() + " parece estar jugando"); }
    public override void walk() { Console.WriteLine(getName() + " es un pez y los peces no caminan. Tienen " + legs + " patas."); }
    public override void eat() { Console.WriteLine(getName() + " esta comiendo."); }
}//fin de la clase fish.

class tester{
    static void Main(){
        spider man = new spider();
        cat gatito = new cat();
        cat gatito2 = new cat("pelusa");
        fish pescadito = new fish();

        Console.WriteLine("Instancia spider.");
        man.walk();
        man.eat();        
               
        Console.WriteLine();

        Console.WriteLine("Instancia cat.");
        gatito.setName("minino");
        gatito.walk();
        gatito.play();        
        gatito.eat();

        Console.WriteLine();

        Console.WriteLine("Instancia cat constructor sobrecargado");
        gatito2.walk();
        gatito2.play();
        gatito2.eat();

        Console.WriteLine();

        Console.WriteLine("Instancia fish.");
        pescadito.setName("flaunder");
        pescadito.walk();
        pescadito.play();
        pescadito.eat();


    }
}
