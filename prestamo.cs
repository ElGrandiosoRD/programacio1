//Camilo Reynoso Adames  100549093

using System;

public class prestamo
{
  //atributos
  private string prestamista;
  private string prestatario;
  private string plazo;
  private double cantidad;
  private bool plazos;
  private int tiempo;//si plazos es false tiempo es igual a un mes.
  private double cuotas;
  private double disponible;
  private bool adquirir;
  private string adquiriendo;
  private double intereses; // el interes es del 15% de uno a 6 meses, del 12% de 7 meses a 24 meses.
  // y de 10% de 25 meses a 60 meses.
   
  //metodos 

  public void pedir(){
//este metodo llama a los setters
//prestatario, prestamista, cantidad, plazos, tiempo.
    setPrestatario("jose");
    setPrestamista("bhd");
    setCantidad(1000);
    setPlazos(false, "si");
    setTiempo(0, getPlazos());
    setDisponible(1000, 1000, 0);
    Console.WriteLine("\nCantidad Disponible: " + getDisponible() + "\n");
    while(getDisponible() < getCantidad()){
        Console.WriteLine("\nCantidad Disponible: " + getDisponible() + "\n");
        setCantidad(1000);
        setPlazos(false, "si");
        setTiempo(0, getPlazos()); 
        setDisponible(1000, 1000, 0);
    }
  }
  public void setDisponible(double cantidad, double disponible, int tiempo){
    //cantidad disponible para prestar,
    cantidad = getCantidad();
    this.cantidad = cantidad;
    tiempo = getTiempo();
    this.tiempo = tiempo;
    if (this.tiempo <= 6){
        disponible = 1000000;
        this.disponible = disponible;
    }
    else if(this.tiempo <= 24){
        disponible = 2000000;
        this.disponible = disponible;
    }
    else if(this.tiempo >= 60){
        disponible = 5000000;
        this.disponible = disponible;
    }

  }
  public void setAdquirir(bool adquirir, string adquiriendo){
    pagar();
do{
    Console.Write("Adquieres el prestamo(si, no)?: ");
    adquiriendo = Console.ReadLine();
    adquiriendo = adquiriendo.ToLower();
    this.adquiriendo = adquiriendo;
    }while(this.adquiriendo != "si" && this.adquiriendo != "no");
    if(this.adquiriendo.Equals("si")){
        adquirir = true;
        this.adquirir = adquirir;
    }
    if(this.adquiriendo.Equals("no")){
         adquirir= false;
        this.adquirir = adquirir;
    }
  }
  public void pagar(){
    setIntereses(1000, 1000, 1);
    setCuotas(1000, 1000, 1000, 1);
    Console.WriteLine("\nPagaras: " + getCuotas() + "\nDurante: " + getTiempo() + " mes.\n");
  }
  public void estado(){
    if (getAdquirir() == true){
        Console.WriteLine("Felicidades.\n");
        Console.WriteLine("Los datos de tu prestamos son: \n");
        Console.WriteLine("Entidad: " + getPrestamista());
        Console.WriteLine("Cliente: " + getPrestatario());
        Console.WriteLine("Monto: " + getCantidad() + " $RD");
        Console.WriteLine("Cuotas: " + getCuotas() + " $RD");
        if(getTiempo() == 1){
        Console.WriteLine("Tiempo: " + getTiempo() + " mes.");
        }
        if(getTiempo() > 1){
           Console.WriteLine("Tiempo: " + getTiempo() + " meses."); 
        }
    }
    else if(getAdquirir()== false){
        Console.WriteLine("Lastima, esperamos verlo pronto.");
    }
  }

  //gettings
  public bool getAdquirir(){
    return this.adquirir;
  }
  public double getDisponible(){
    return this.disponible;
  }
  public string getPrestatario(){
    return this.prestatario;
  }
  public string getPrestamista(){
    return this.prestamista;
  }
  public double getCantidad(){
    return this.cantidad;
  }
  public bool getPlazos(){
    return this.plazos;
  }
  public int getTiempo(){
    return this.tiempo;
  }
  public double getCuotas(){
    return this.cuotas;
  } 
  public double getIntereses(){
    return this.intereses;
  }

  //settings
  public void setPrestamista(string prestamista){
    Console.Write("Quien es el prestamista?: ");
    prestamista = Console.ReadLine();
    this.prestamista = prestamista;
  }
  public void setPrestatario(string prestatario){
    Console.Write("Quien solicita el prestamo?: ");
    prestatario = Console.ReadLine();
    this.prestatario = prestatario;
  }
  public void setCantidad(double cantidad){
    Console.Write("Que cantidad solicita?: ");
    cantidad = double.Parse(Console.ReadLine());
    this.cantidad = cantidad;
  }
  public void setPlazos(bool plazos, string plazo){
    do{
    Console.Write("A plazos (si, no): ");
    plazo = Console.ReadLine();
    plazo = plazo.ToLower();
    this.plazo = plazo;
    }while(this.plazo != "si" && this.plazo != "no");
    if(this.plazo.Equals("si")){
        plazos = true;
        this.plazos = plazos;
    }
    if(this.plazo.Equals("no")){
        plazos = false;
        this.plazos = plazos;
    }
  }
  public void setTiempo(int tiempo, bool plazos){
    this.plazos = plazos;
    if (this.plazos == true){
        do{
    Console.Write("A cuantos meses(maximo 60): ");
    tiempo = int.Parse(Console.ReadLine());
    this.tiempo = tiempo;
        }while(this.tiempo < 1 || this.tiempo > 60);
    }
    else {
        tiempo = 1;
        this.tiempo = tiempo;
    }

  }
  public void setCuotas(double cuotas, double interes, double cantidad, int tiempo){
    interes = getIntereses();
    this.intereses = interes;
    tiempo = getTiempo();
    this.tiempo = tiempo;
    cantidad = getCantidad();
    this.cantidad = cantidad;
    cuotas = (this.cantidad + this.intereses) / this.tiempo;
    this.cuotas = cuotas;
  }
  public void setIntereses(double intereses, double cantidad, int tiempo){
// el interes es del 15% de uno a 6 meses, del 12% de 7 meses a 24 meses.
// y de 10% de 25 meses a 60 meses.
tiempo = getTiempo();
this.tiempo = tiempo;
cantidad = getCantidad();
this.cantidad = cantidad;
if(this.tiempo == 1 || this.tiempo <= 6){
    intereses = ((this.cantidad * 15)/100);
    this.intereses = intereses;
}
else if (this.tiempo <= 24 ){
    intereses = ((this.cantidad * 12)/100);
    this.intereses = intereses;
}
else if (this.tiempo <= 60 ){
    intereses = ((this.cantidad * 10)/100);
    this.intereses = intereses;
}
  }    
}
public class prestamoTest{
    static void Main(){
    prestamo cliente1 = new prestamo();
    cliente1.pedir();
    
    cliente1.setAdquirir(false, "no");
    cliente1.estado();
    }
    
}