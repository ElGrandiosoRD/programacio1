using System;

class Animal{
    public virtual void eat(){
        Console.WriteLine("Esta comiendo.");
    }
}
class Bird: Animal{
    public void takeOff() { Console.WriteLine("El ave esta despegando.");}
    public void land() {Console.WriteLine("El ave esta aterrizando.");}
    public void fly() {Console.WriteLine("El ave esta volando.");}
    public void builNest() {Console.WriteLine("El ave esta construyendo un nido.");}
    public void layEggs(){Console.WriteLine("El ave esta poniendo huevos.");}
    public override void eat(){Console.WriteLine("El ave esta comiendo.");} 
    }
class Kriptonian: Animal{}
class Superman: Kriptonian{
    public void takeOff() {Console.WriteLine("Superman esta despegando.");}
    public void land() {Console.WriteLine("Superman esta aterrizando.");}
    public void fly() {Console.WriteLine("Superman esta volando");}
    public void leapBuilding() {Console.WriteLine("Superman salto un edificio.");}
    public void stopBullet() {Console.WriteLine("Superman detiene una bala.");}
    public override void eat() {Console.WriteLine("Superman esta comiendo.");}
}
class tester{
    static void Main(){
        Bird avecilla = new Bird();
        Superman clark = new Superman();

        avecilla.takeOff();
        avecilla.fly();
        avecilla.land();
        avecilla.builNest();
        avecilla.layEggs();
        avecilla.eat();

        Console.WriteLine("");

        clark.takeOff();
        clark.fly();
        clark.land();
        clark.leapBuilding();
        clark.stopBullet();
        clark.eat();

    }
}