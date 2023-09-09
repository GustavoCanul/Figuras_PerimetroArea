
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

        Console.WriteLine("Ingrese el valor de una de las caras del cuadrado");
        double lados = Convert.ToDouble(Console.ReadLine());

        Cuadrado cuadrado = new Cuadrado(lados);
        Console.WriteLine("Área del cuadrado: "+cuadrado.CalcularArea());
        Console.WriteLine("Perimetro del cuadrado: "+cuadrado.CalcularPerimetro());

        Console.WriteLine("Ingrese el valor del lado Horizontal");
        double ladoH = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor del lado Vertical");
        double ladoV = Convert.ToDouble(Console.ReadLine());

        Rectangulo rectangulo = new Rectangulo(ladoH, ladoV);
        Console.WriteLine("El Área del rectangulo es: "+rectangulo.CalcularArea());
        Console.WriteLine("El Perimetro del rectangulo es: "+rectangulo.CalcularPerimetro());


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

public class Rectangulo : Figura{
    private double ladoH;
    private double ladoV;
    
    public double _ladoH{
        get{return ladoH;}
        set{
            if(value >= 0){
                ladoH = value;
            }else{
                throw new ArgumentException("El valor no puede ser de valor negativo");
            }
        }
    }
    public double _ladoV{
        get{return ladoV;}
        set{
            if(value >= 0 && value != ladoH){
                ladoV = value;
            }else{
                throw new ArgumentException("El valor no puede ser de valor negativo o diferente ");
            }
        }
    }
    public Rectangulo(double ladoH, double ladoV){
        this._ladoH = ladoH;
        this._ladoV = ladoV;
    }
    public override double CalcularPerimetro(){
        return 2*_ladoH + _ladoV*2;
    }
    public override double CalcularArea(){
        return _ladoH * _ladoV;
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