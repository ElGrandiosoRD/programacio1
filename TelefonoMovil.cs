// Camilo Reynoso Adames 100549093
using System;
class TelefonoMovil{

/* 

Atributos de clase.

Debajo se encuentran las definiciones de los atributos de la clase TelefonoMovil.
Realice los cambios en los atributos y metodos que sean necesarios para encapsular
la clase TelefonoMovil.
  
*/

    private string marca;
    private string color;
    private string modelo;
    private int cantidadCamaras;
    private int size;
    private string estado;
    private int bateria; // atributo para la condicion agregada por mi.
/* 

Metodos de acceso: getters y setters.

En este espacio defina los metodos get y set que sean necesarios para 
encapsular la clase TelefonoMovil.
  
*/
//gets
    public string getMarca(){
        return this.marca;
    }
    public string getColor(){
        return this.color;
    }
    public string getModelo(){
        return this.modelo;
    }
    public int getCantidadCamaras(){
        return this.cantidadCamaras;
    }
    public int getSize(){
        return this.size;
    }
    public string getEstado(){
        return this.estado;
    }
    public int getBateria(){//get para la nueva condicion.
        return this.bateria;
    }

    //sets
    public void setMarca(string marca){
        this.marca = marca;
    }
    public void setColor(string color){
        this.color = color;
    }
    public void setModelo(string modelo){
        this.modelo = modelo;
    }
    public void setCantidadCamaras(int cantidadCamaras){
        this.cantidadCamaras = cantidadCamaras;
        while(this.cantidadCamaras > 8 || this.cantidadCamaras < 0){
            Console.WriteLine("Las camaras no pueden ser mas de 8, ni menos que 0.");
            Console.Write("Entre una cantidad de camaras en el rango: ");
            this.cantidadCamaras = int.Parse(Console.ReadLine());
        }
    }
    public void setSize(int size){
        this.size = size;
        while(this.size > 7 || this.size <= 0){
            Console.WriteLine("El tamaño minimo es de 1 pulgada y el maximo de 7.");
            Console.Write("Entre un tamaño en el rango: ");
            this.size = int.Parse(Console.ReadLine());
        }
    }
    public void setEstado(string estado){
        estado = estado.ToUpper();
        if (estado.Equals("ENCENDIDO") || estado.Equals("SUSPENDIDO") || estado.Equals("APAGADO")){
            this.estado = estado;
        } else {
            do{
            Console.WriteLine("Estados permitidos: ENCENDIDO, SUSPENDIDO, APAGADO.");
            Console.Write("Debe corregir el estado: " );
            estado = Console.ReadLine();
            estado = estado.ToUpper();
            this.estado = estado;
            }while(this.estado != "ENCENDIDO" && this.estado != "SUSPENDIDO" && this.estado != "APAGADO");
        }
    }
    //con el siguiente metodo agregamos la capacidad de la bateria.
    //la bateria tendra una capacidad no mayor a 10K mili amperes y no menor a 3500 miliamperes. 
    public void setBateria(int bateria){
        this.bateria = bateria;
        while(this.bateria > 10000 || this.bateria < 3500){
            Console.WriteLine("La capacidad minima es de 3500 Mili Amperes y la maxima de 10000 mili Amperes.");
            Console.Write("Entre una capacidad en el rango: ");
            this.bateria = int.Parse(Console.ReadLine());
        }

    }
}

class TelefonoMovilTest{
    public static void Main(){
        TelefonoMovil miCelular = new TelefonoMovil();
        miCelular.setMarca("Samsung");
        miCelular.setColor("Negro");
        miCelular.setModelo("A50");
        miCelular.setCantidadCamaras(1000);
        miCelular.setSize(6);
        miCelular.setEstado("Sumergido en agua");
        miCelular.setBateria(500);//dando un estado a la nueva caracteristica.

        Console.WriteLine("\n*** Salida ***\n");
        Console.WriteLine("Marca:                   " + miCelular.getMarca());
        Console.WriteLine("Color:                   " + miCelular.getColor());
        Console.WriteLine("Modelo:                  " + miCelular.getModelo());
        Console.WriteLine("Cantidad Camaras:        " + miCelular.getCantidadCamaras());
        Console.WriteLine("Tamaño:                  " + miCelular.getSize());
        Console.WriteLine("Estado:                  " + miCelular.getEstado()); 
        Console.WriteLine("Capacidad de la Bateria: " + miCelular.getBateria() + " Mili Amperes.");//obteniedo el estado de la nueva caracteristica.   
    }
}
