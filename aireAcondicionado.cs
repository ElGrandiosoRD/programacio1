using System;
using System.Threading.Tasks;

class AireAcondicionado{
    //variables
    private string marca;
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
        if (prendido){
            Console.WriteLine("Ya estaba encendido.");
            Task.Delay(1000).Wait();}
        else {
            prendido = true;
            vFan = 1;
            temperatura = 17;
            Console.Write("Encendiendo");
            for(int i=0; i<3; ++i){
            Task.Delay(1000).Wait(); 
            Console.Write(".");
            }
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
        else {
            Console.WriteLine("Ya estaba apagado");
            Task.Delay(1000).Wait();
            }
    }
    public void subirTemperatura(){
        //-	Decrementa en 1, el valor de la temperatura.
        if(prendido){
            if (temperatura == 17){
                Console.WriteLine("Temperatura minima alcanzada. " + temperatura + " C");
                Task.Delay(1000).Wait();}
            else {
                --temperatura;
                //Console.WriteLine("Temperatura: " + temperatura + " C"); 
            }
        }
        else{
            Console.WriteLine("Debes encenderlo para poder modificar la temperatura");
            Task.Delay(1000).Wait();} 
    }
    public void bajarTemperatura(){
        //-	Incrementa en 1, el valor de la temperatura.
        if(prendido){
            if (temperatura == 26){
                Console.WriteLine("Temperatura maxima alcanzada. " + temperatura + " C");
                Task.Delay(1000).Wait();}
            else {
                ++temperatura;
                //Console.WriteLine("Temperatura: " + temperatura + " C"); 
            }
        }
        else{
            Console.WriteLine("Debes encenderlo para poder modificar la temperatura");
            Task.Delay(1000).Wait();} 
    }
    public void subirVelocidadDelFan(){
        //-	El abanico del aire tiene solo cuatro velocidades. 
        //Este método incrementa en 1 la velocidad del abanico.
        if(prendido){
            if (vFan == 4){
                Console.WriteLine("El abanico ya esta al maximo.");
                Task.Delay(1000).Wait();}
            else {
                ++vFan;
                //Console.WriteLine("Velocidad abanico: " + vFan);
            }
        } 
        else{
            Console.WriteLine("Debes encenderlo para poder modificar la velocidad del abanico.");
            Task.Delay(1000).Wait();}      
    }
    public void bajarVelocidadDelFan(){
        //-	El abanico del aire tiene solo cuatro velocidades.
        // Este método decrementa en 1 la velocidad del abanico.
        if(prendido){
            if (vFan == 1){
                Console.WriteLine("El abanico ya esta al minimo.");
                Task.Delay(1000).Wait();}
            else {
                --vFan;
                //Console.WriteLine("Velocidad abanico: " + vFan);
            }
        }
        else{
            Console.WriteLine("Debes encenderlo para poder modificar la velocidad del abanico.");
            Task.Delay(1000).Wait();}
    }
    public void verEstado(){
        Console.Clear();
        Console.WriteLine("Marca: " + marca);
        if(prendido){Console.WriteLine("Encendido: " + prendido);}
            else{Console.WriteLine("Encendido: stand-by");}
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
    static void menu2(){
        Console.Write(
            "Opciones.\n"
            + "1) Encender.\n"
            + "2) Apagar.\n"
            + "3) Subir Temperatura.\n"
            + "4) Bajar Temperatura. \n"
            + "5) Subir velocidad del abanico.\n"
            + "6) Bajar velocidad del abanico.\n"
            + "0) Salir.\n" 
            + "=>"
        );
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
        switch(eleccion)
        {
            case 1:
                marca = "SAMSUNG";
                break;
            case 2:
                marca = "HAIER";
                break;
            case 3:
                marca = "NEDOCA";
                break;
        }

        AireAcondicionado mio = new AireAcondicionado(marca);
        
        do{
           
            do{
                mio.verEstado();
                Console.WriteLine("**************");
                menu2();
                elegir = Console.ReadLine();
                prueba = int.TryParse(elegir, out eleccion);
                if(eleccion > 6 || eleccion < 0){
                    Console.Clear();
                    Console.WriteLine("Opciones del 0 al 6.");
                    Task.Delay(2000).Wait();
                }
            
                if(prueba == false){
                    Console.WriteLine("Solo numeros.");
                    Task.Delay(2000).Wait();
                    }
            }while(prueba == false || eleccion > 6 || eleccion < 0);
            switch (eleccion)
            {
               case 1:
                    mio.encender();
                    break;
               case 2:
                    mio.apagar();
                    break;
                case 3:
                    mio.subirTemperatura();
                    break;
                case 4:
                    mio.bajarTemperatura();
                    break;
                case 5:
                    mio.subirVelocidadDelFan();
                    break;
                case 6:
                    mio.bajarVelocidadDelFan();
                    break;
            }

        }while(eleccion != 0);
        mio.verEstado();
        
    }
}
