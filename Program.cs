
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

        Console.WriteLine("Ingrese el valor de los lados");
        double lados = Convert.ToDouble(Console.ReadLine());

        Cuadrado cuadrado = new Cuadrado(lados);
        Console.WriteLine("Área del cuadrado: "+cuadrado.CalcularArea());
        Console.WriteLine("Perimetro del cuadrado: "+cuadrado.CalcularPerimetro());

    }
}

public abstract class Figura{
    public abstract double CalcularPerimetro();
    public abstract double CalcularArea();

}

public class Circulo : Figura{
    private double _radio; //esta sera mi variable de respaldo o mi contenedor:3
    public double radio{//Propiedad radio e intento de validacion
        get{return _radio;}  //accedemos a mi variable de respaldo
        set{//realizamos la validacion y si es validad, podremos usar el valor de la propiedad radio
            if(value >= 0){
                _radio = value;//se valida y se respalda en mi variable _radio
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
    private double lados;

    public double _lados{//Propiedad _lados y intento de validacion
        get{return lados;}
        set{
            if(value >= 0){
                lados = value;
            }else{
                throw new ArgumentException("Debe de ser un valor positivo");
            }
        }
    }
    public Cuadrado(double lados){
        this._lados = lados;

    }
    public override double CalcularArea(){
        return _lados * _lados;
    }
    public override double CalcularPerimetro(){
        return _lados * 4;
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