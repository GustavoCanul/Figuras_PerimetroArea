
using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el valor del radio del círculo:");
        double radio = Convert.ToDouble(Console.ReadLine());

        Circulo miCirculo = new Circulo(radio);

        Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

        Console.WriteLine("Ingrese el valor del lado1");
        double lado1 = Convert.ToDouble(Console.ReadLine());
    }
}

public abstract class Figura{
    public abstract double CalcularPerimetro();
    public abstract double CalcularArea();

}

public class Circulo : Figura{
    private double _radio;
    public double radio{
        get{return _radio;}  
        set{
            if(value >= 0){
                _radio = value;
            }else{
                Console.WriteLine("Prueba para la consola");
                throw new ArgumentException("El radio debe de ser un valor positivo");
            }
        }
    }
    public Circulo(double radio){
        this.radio = radio;
    }
    
    public override double CalcularPerimetro(){
        return (radio*2) * Math.PI;
    }

    public override double CalcularArea(){
        return Math.PI * (Math.Pow(radio, 2));
    }
}
public class Cuadrado : Figura{
    private double lado1;
    private double lado2;
    public double _lado1{
        get{return lado1;}
        set{
            if(value >= 0){
                _lado1 = value;
            }
            else{
                throw new ArgumentException("Debe de ser un valor positivo");
            }
        }
    }
    public double _lado2{
        get{return lado2;}
        set{
            if(value >= 0 && value == lado2){
                _lado2 = value;
            }else{
                throw new ArgumentException("Debe de ser un valor positivo o igual al otro lado");
            }
        }
    }
    public Cuadrado(double lado1, double lado2){
        this._lado1 = lado1;
        this._lado2 = lado2;
    }
    public override double CalcularArea(){
        return _lado1 * _lado2;
    }
    public override double CalcularPerimetro(){
        return _lado1 * 4;
    }
}

















/*CalculadoraGeometrica miRectangulo = new CalculadoraGeometrica();
 
Console.WriteLine("Agrega el radio de tu circulo");
double radio = double.Parse(Console.ReadLine()!);

double respuesta = miRectangulo.PerimetroCirculo(radio);
Console.WriteLine("El perimetro es: "+respuesta);
public class CalculadoraGeometrica{
    
    public double PerimetroCirculo(double radio){
        double diametro = radio * 2;
        double perimetro = Math.PI * diametro;
        return perimetro;
    }
}
*/