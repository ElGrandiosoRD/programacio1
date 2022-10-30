// Camilo Reynoso Adames  100549093
using System;

public class elevador{
// declaracion de variables.
private bool abre;
private string puerta;
private int inicial;
private int tope;
private int mañanas;
//private int noches;
private int piso;
private int requerido;

//setters
public void setPiso(){
    do{
    Console.Write("A que piso desea ir: ");
    piso = int.Parse(Console.ReadLine());
    if(piso < 1 || piso > 12){
        Console.WriteLine("ERROR. El piso mas bajo es el piso 1 y el mas alto es el piso 12.");
    }
    if(piso == getInicial()){
        Console.WriteLine("Ya estamos en el piso " + piso);
    }
}while(piso < 1 || piso > 12 || piso == getInicial());
}

public void setInicial (int inicial){
    this.inicial = inicial;
}
public void setTope (int tope){
tope = 12;
this.tope = tope;
}
public void setAbre(){
    if(abre == false){
    Console.WriteLine("Abriendo puertas.");
    }
    Console.WriteLine("Puertas abiertas.");
    abre = true;
}
public void cierra(){
    if (getAbre() == true){
    Console.WriteLine("Cerrando Puertas.");
    }
    Console.WriteLine("Puertas cerradas.");
    abre = false;
}
public void setMañanas(){
    mañanas++;
}
public void setRequerido(){
    do{
    Console.Write("Desde cual piso piden el elevador: ");
    requerido = int.Parse(Console.ReadLine());
    }while(requerido < 1 || requerido > 12);
    piso = requerido;
    if(requerido == getInicial()){
        setAbre();
    }
    if(getInicial() < requerido){
        subir();
         
    }
    else if(getInicial() > requerido){
        bajar();
        
    }                                                     
}

//getters
public int getPiso(){
    return piso;
}
public int getInicial(){
    return this.inicial;
}
public int getTope(){
    return this.tope;
}
public bool getAbre(){
    return this.abre;
}
public int getMañanas(){
    return mañanas;
}
//operaciones
public void subir(){
    while(getAbre() == true){
        Console.WriteLine("Puertas abiertas.");
        Console.WriteLine("Cerrar puertas(si, no)? ");
        puerta = Console.ReadLine();
        puerta.ToLower();
        if(puerta == "si"){
            cierra();
        }
    }
    Console.WriteLine("Subiendo.");
    do{
     Console.WriteLine("Piso " + getInicial());
     this.inicial++;
    }while(getInicial() < getPiso());
    Console.WriteLine("Piso " + getInicial() + " alcanzado.");
    setAbre();
    }
public void bajar(){
    while(getAbre() == true){
        Console.WriteLine("Puertas abiertas.");
        Console.WriteLine("Cerrar puertas(si, no)? ");
        puerta = Console.ReadLine();
        puerta.ToLower();
        if(puerta == "si"){
            cierra();
        }
    }
Console.WriteLine("Bajando.");
    do{
     Console.WriteLine("Piso " + getInicial());
     this.inicial--;
    }while(getInicial() > getPiso());
    Console.WriteLine("Piso " + getInicial() + " alcanzado.");
    setAbre();
}

public void automatico(){
    if(getInicial() < getPiso()){
        subir();
        Console.WriteLine("Tenga un buen dia.\n");
    }
    if(getInicial() > getPiso()){
        bajar();
        Console.WriteLine("Tenga un buen dia.\n");
    }
}
public void encendido (int mañanas, int piso){
this.mañanas = mañanas;
if (this.mañanas == 6){
    Console.WriteLine("\nPiso " + piso);
    setAbre();
    mensaje();
}
}
public void apagado (){
    Console.WriteLine("Son Las " + getMañanas() + " Horas");
    Console.WriteLine("Fin del horario de servicio.\n Elevador Apagado.");

}
public void seleccione(){
    setPiso();
    Console.WriteLine("Piso seleccionado " + getPiso());
}


public void mensaje(){
    Console.WriteLine("Bienvenido a ELEVATORWELL. Póngase cómodo y seleccione un piso hacia donde quiere ir. ");

}
//constructor
public elevador(){
    mañanas = 6;
    piso = 1;
    inicial = piso;
    encendido(mañanas, piso);
}
//destructor
~elevador(){
    apagado();
}
}

public class testelevador{
    static int Main(){
        elevador ELEVATORWELL = new elevador();
        ELEVATORWELL.setPiso();
        ELEVATORWELL.automatico();
        do{
            ELEVATORWELL.setRequerido();
            ELEVATORWELL.setPiso();
            Console.WriteLine("Son las " + ELEVATORWELL.getMañanas() + " Horas.");
            ELEVATORWELL.automatico();
            ELEVATORWELL.setMañanas();
        }while(ELEVATORWELL.getMañanas() > 6 && ELEVATORWELL.getMañanas() < 22);
       return 0;    
    }
}