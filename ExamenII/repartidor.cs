//Clase Hija
class repartidor:empleado
{
    public string zona {get; set;}
    double plus = 300;
    //constructor
    public repartidor(string nombre, int edad, double salario, string zona):base(nombre, edad, salario){
        this.salario = salario;
        this.zona = zona;
    }
    //Metodos
    public override double Calculo()
    {
        double nuevosalario;
        if(edad< 25 && zona == "Zona 3"){
            nuevosalario = salario + plus;
            return(nuevosalario);
        }else{
            nuevosalario = salario;
            return(nuevosalario);
        }
    }
    public override void toString()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("---------Repartidor--------");
        Console.WriteLine("Nombre: "+nombre);
        Console.WriteLine("Edad: "+edad);
        Console.WriteLine("Salario base: "+salario);
        Console.WriteLine("Nuevo salario: "+Calculo());
        Console.WriteLine("Zona: "+zona);
        Console.WriteLine("--------------------------");
    }
}