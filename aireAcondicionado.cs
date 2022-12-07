using System;
using System.Threading.Tasks;

class AireAcondicionado{
    //variables
    private string marca = "xxx";
    private int temperatura;
    private byte vFan;
    private bool prendido;
    //constructor
    public AireAcondicionado (string marca){
        this.marca = marca;
        temperatura = 17;
        vFan = 1;
        prendido = true; 
    }
    //metodos
    public void encender(){
        if (prendido){Console.WriteLine("Ya estaba encendido.");}
        else {
            prendido = true;
            vFan = 1;
            temperatura = 17;
            Console.WriteLine("Encendiendo...");
        }
    }
    public void apagar(){
        if(prendido){
            prendido = false;
            vFan = 0;
            temperatura =0;
            Console.Write("Apagando");
            for(int i=0; i<3; ++i){
            Task.Delay(1000).Wait(); 
            Console.Write(".");
            }
            Console.WriteLine();
        }
        else {Console.WriteLine("Ya estaba apagado");}
    }
    public void subirTemperatura(){
        //-	Decrementa en 1, el valor de la temperatura.
        if (temperatura == 17){Console.WriteLine("Temperatura minima alcanzada." + temperatura + " C");}
        else {
            --temperatura;
            Console.WriteLine("Temperatura: " + temperatura + " C"); 
        }
    }
    public void bajarTemperatura(){
        //-	Incrementa en 1, el valor de la temperatura.
        if (temperatura == 26){Console.WriteLine("Temperatura maxima alcanzada." + temperatura + " C");}
        else {
            ++temperatura;
            Console.WriteLine("Temperatura: " + temperatura + " C"); 
        }
    }
    public void subirVelocidadDelFan(){
        //-	El abanico del aire tiene solo cuatro velocidades. 
        //Este método incrementa en 1 la velocidad del abanico.
        if(prendido){
            if(prendido){
                 if (vFan == 4){Console.WriteLine("El abanico ya esta al maximo.");}
                 else {
                    ++vFan;
                    Console.WriteLine("Velocidad abanico: " + vFan);
                }
            }
        else{Console.WriteLine("Debes encenderlo para poder modificar la velocidad del abanico.");}
        }       
    }
    public void bajarVelocidadDelFan(){
        //-	El abanico del aire tiene solo cuatro velocidades.
        // Este método decrementa en 1 la velocidad del abanico.
        if(prendido){
            if (vFan == 0){Console.WriteLine("El abanico ya esta al minimo.");}
            else {
                --vFan;
                Console.WriteLine("Velocidad abanico: " + vFan);
            }
        }
        else{Console.WriteLine("Debes encenderlo para poder modificar la velocidad del abanico.");}
    }
    public void verEstado(){
        Console.Clear();
        Console.WriteLine("Marca: " + marca);
        Console.WriteLine("Encendido: " + prendido);
        if(prendido == false){Console.WriteLine("Temperatura: null");}
        else {Console.WriteLine("Temperatura: " + temperatura + " C");}
        if (prendido == false){Console.WriteLine("Abanico: null");}
        else {Console.WriteLine("Abanico: " + vFan);}
    }
     
}

class tester{
    static string marca="null";
    static string elegir;
    static int eleccion = 1;
    static bool prueba = true;
    static void menu1(){
        Console.Clear();
        
        Console.Write("Elija una marca:\n"
        + "1) SAMSUNG.\n"
        + "2) HAIER.\n"
        + "3) NEDOCA.\n"
        + "=>");
    }    
        
   
    static void Main(){
        
        
        
        do{            
            menu1();
            elegir = Console.ReadLine();
            prueba = int.TryParse(elegir, out eleccion);
            if(eleccion > 3 || eleccion < 1){
                Console.Clear();
                Console.WriteLine("Opciones del 1 al 3.");
                Task.Delay(2000).Wait();
            }
            
            if(prueba == false){
                Console.WriteLine("Solo numeros.");
                Task.Delay(2000).Wait();
                }
            
        
        }while(eleccion != 1 && eleccion != 2 && eleccion != 3);
        if (eleccion == 1){marca = "SAMSUNG"; }
        else if(eleccion == 2) {marca = "HAIER"; }
        else if(eleccion == 3) {marca = "NEDOCA";}

        AireAcondicionado mio = new AireAcondicionado(marca);

        mio.verEstado();
        Console.WriteLine("*********");
        mio.encender();
                Console.WriteLine("*********");
        mio.verEstado();
        Console.WriteLine("*********");
        mio.apagar();
         Console.WriteLine("*********");
        mio.verEstado();
                Console.WriteLine("*********");
        mio.apagar();
                Console.WriteLine("*********");
        mio.verEstado();
    }
}
