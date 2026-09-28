using System;
// 1. Crear CuentaBancaria con saldo privado y metodos Depositar/Retirar.
// 2. Demostrar que _saldo no es accesible directamente desde afuera.
// 3. Agregar validacion en Retirar: no retirar mas del saldo.
// 4. Crear clase Temperatura con propiedad que valide > -273.
// 5. Usar const para IVA = 0.21m.
// 6. Usar readonly para el ID de cuenta generado en constructor.
// 7. Crear propiedad de solo escritura (solo set).
// 8. Crear propiedad calculada: Perimetro => 2 * (Ancho + Alto).
// 9. Agregar propiedad Edad con validacion 0 a 150.
// 10. Crear clase Persona con todas las propiedades correctamente encapsuladas.

public class CuentaBancaria
{
    private decimal _saldo;
    private readonly string _idCuenta;

    public string IdCuenta => _idCuenta;

    public CuentaBancaria(string idCuenta)
    {
        _idCuenta = idCuenta;
        _saldo = 0;
    }
    public void Depositar(decimal monto){
        if (monto > 0){_saldo += monto;
        Console.WriteLine($"Se depositaron: {monto} correctamente");}
    }

    public void Retirar(decimal monto)
    {
        if (monto <= 0) {Console.WriteLine("El monto a retirar debe ser mayor a 0.");}
        else if (monto > _saldo){Console.WriteLine("Fondos insuficientes.");}
        else{_saldo -= monto;}
    }
}
public class Temperatura
{
    private double _celsius;

    public double Celsius
    {
        get => _celsius;
        set
        {
            if (value < -273.15){
                Console.WriteLine("Error: La temperatura no puede ser menor a -273.15 °C.");
            
            }                  
            else{
                _celsius = value;
            }
        }
    }
}
public class Impuestos
{
    public const decimal IVA = 0.21m;
}
public class ReglaAuditoria
{
    private string _claveSecreta;

    public string ClaveAcceso
    {
        set => _claveSecreta = value;
}}
public class Rectangulo
{public double Ancho { get; set; }
public double Alto { get; set; }
public double Perimetro => 2 * (Ancho + Alto);}
public class Persona{
    private string _nombre;
    private int _edad;

    public string Nombre
    {
        get => _nombre;
        set
        {
            if (value != null && value != "" && value != " ")
            {
                _nombre = value;
            }
            else
            {
                Console.WriteLine("El nombre no puede estar vacio ni ser un espacio.");
            }
        }
    }

    public int Edad
    {
        get => _edad;
        set
        {
            if (value >= 0 && value <= 150)
            {
                _edad = value;
            }
            else
            {
                Console.WriteLine("La edad debe estar entre 0 y 150 años.");
            }
        }
    }
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}

    class Program
    {
        static void Main()
        {
            CuentaBancaria miCuenta = new CuentaBancaria("001");
            //lo dejo como comentario para probar el codigo pero es la consigna 2 de demostrar un eror
            // Console.WriteLine(miCuenta._saldo);
            miCuenta.Depositar(100000000m);
            miCuenta.Retirar(2000.000m);
        }
    }
    
