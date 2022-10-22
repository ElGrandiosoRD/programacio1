//Camilo Reynoso Adames 100549093

using System;

public class Mouse{
    //bloque variables
    private string marca;
    private string modelo;
    private string tipo;
    private string color; //Colores permitidos: Rojo, Verde, Azul.
    private bool ergonomico;
    private float precio;

    

    
//bloque gets
    public string getMarca(){
        return this.marca;
    }

    public string getModelo(){
    return this.modelo;       
    }

    public string getTipo(){
        return this.tipo;
    }
    

    public string getColor(){
        return this.color;
    }

    public bool getErgonomico(){
        return this.ergonomico;
    }

    public float getPrecio(){
        return this.precio;
    }
//bloque sets
 public void setMarca(string marca){
        marca = marca.ToUpper();
        if (marca.Equals("DELL") || marca.Equals("GENIUS") || marca.Equals("LOGITEC")){
            this.marca = marca;
        } else {
            do{
            Console.WriteLine("Error. Marca Invalida.");
            Console.WriteLine("Marcas permitidas: DELL, GENIUS, LOGITEC.");
            Console.Write("Debe corregir la marca: " );
            marca = Console.ReadLine();
            marca = marca.ToUpper();
            this.marca = marca;
            }while(this.marca != "DELL" && this.marca != "GENIUS" && this.marca != "LOGITEC");
        }
    }

    public void setModelo(string modelo){
        modelo = modelo.ToUpper();
        this.modelo = modelo;
    }

  public void setTipo(string tipo){
        tipo = tipo.ToUpper();
        if (tipo.Equals("MECANICO") || tipo.Equals("OPTICO") || tipo.Equals("LASER")){
            this.tipo = tipo;
        } else {
            do{
            Console.WriteLine("Error. Tipo Invalido.");
            Console.WriteLine("Tipos permitidos: MECANICO, OPTICO, LASER.");
            Console.Write("Debe corregir el Tipo: " );
            tipo = Console.ReadLine();
            tipo = tipo.ToUpper();
            this.tipo = tipo;
            }while(this.tipo != "MECANICO" && this.tipo != "OPTICO" && this.tipo != "LASER");
        }
    }

    public void setColor(string color){
        color = color.ToUpper();
        if (color.Equals("ROJO") || color.Equals("VERDE") || color.Equals("AZUL")){
            this.color = color;
        } else {
            do{
            Console.WriteLine("Error 2. Color Invalido.");
            Console.WriteLine("Colores permitidos: ROJO, VERDE, AZUL.");
            Console.Write("Debe corregir color: " );
            color = Console.ReadLine();
            color = color.ToUpper();
            this.color = color;
            }while(this.color != "ROJO" && this.color != "VERDE" && this.color != "AZUL");
        }
    }

    public void setErgonomico(bool ergonomico){
        this.ergonomico = ergonomico;
    }

   public void setPrecio(float precio){
               
         this.precio = precio;
            while(this.precio < 0.0 || this.precio > 50.0){
            Console.WriteLine("Error 1. Precio Invalido.");
            Console.Write("Introdusca un precio valido (0.0 - 50.0): ");
            this.precio = float.Parse(Console.ReadLine());
            }
    }

   
    public void desplegarInformacion(){
        Console.WriteLine("Marca: " + getMarca());
        Console.WriteLine("Modelo: " + getModelo());
        Console.WriteLine("Tipo: " + getTipo());
        Console.WriteLine("Ergonomico: " + getErgonomico());
        Console.WriteLine("Color: " + getColor());
        Console.WriteLine("Precio: " + getPrecio());

    }

     
    }


public class MouseTest{
    static void Main(){
        Mouse raton1 = new Mouse();
        raton1.setMarca("dell");
        raton1.setModelo("1n7054");
        raton1.setTipo("optico");
        raton1.setColor("verde");
        raton1.setErgonomico(true);
        raton1.setPrecio(50);
        //raton1.setPrecio();
        //raton1.getColor();
        raton1.desplegarInformacion();
    }
}
