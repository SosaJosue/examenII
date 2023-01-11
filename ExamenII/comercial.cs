//Clase Hija 
class comercial:empleado
{
    public double comision {get; set;}
    double plus = 300;
    //Constructor
    public comercial (string nombre, int edad, double salario, double comision):base(nombre, edad, salario){
        this.salario = salario;
        this.comision = comision;
    }
    //Metodos
    public override double Calculo()
    {
        double nuevosalario;
        if(edad > 30 && comision == 200){
            nuevosalario= salario + plus;
            return(nuevosalario);
        }else{
            nuevosalario = salario;
            return(nuevosalario);
        }
    }
    public override void toString()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("---------Comercial--------");
        Console.WriteLine("Nombre: "+nombre);
        Console.WriteLine("Edad: "+edad);
        Console.WriteLine("Salario base: "+salario);
        Console.WriteLine("Nuevo salario: "+Calculo());
        Console.WriteLine("--------------------------");
    }
}