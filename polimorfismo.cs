using System;

abstract class Animal{
    protected int legs;
    protected Animal(int legs){
        this.legs = legs;
    }
    public void walk(){}
    public virtual void eat(){} 
}
interface IPet{
    string getName();
    void setName(string n);
    void play(); 
}
class spider: Animal{

    public spider(): base(8){}//constructor
    public override void eat (){}//metodo

}
class cat: Animal, IPet{
    private string name;

    //constructores
    public cat(string n): base(4){}
    public cat(): base(4){}

    //metodos
    public string getName(){}
    public void setName(string n){}
    public void play(){}
    public void eat(){}
}
class fish: Animal, IPet{
    private string name;

    //constructor
    public fish(): base(0){}

    //metodos
    public string getName(){}
    public void setName(string n){}
    public void play(){}
    public void walk(){}
    public void eat(){}

}
