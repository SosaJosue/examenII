//Clase Padre
abstract class empleado
{
    public string nombre {get; set;}
    public int edad {get; set;}
    public double salario {get; set;}
    //Constructor
    public empleado (string nombre, int edad, double slario){
        this.nombre = nombre;
        this.edad  = edad;
        this.salario = salario;
    }
    //Metodos
    public abstract void toString();
    public abstract double Calculo();
}