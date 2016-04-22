using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carro;

namespace llamarcarro
{
    static class Program
    {
        static Carro carrodepaseo = new Carro();

        static void Main(string[] args)
        {
            carrodepaseo.velocidadmaxima = 150;
            carrodepaseo.galones = 31;
            carrodepaseo.velocidad = 0;
            carrodepaseo.distanciarecorrida = 0;
            prendercarro();

            while (carrodepaseo.cambio != -1)

            {                
                acelerar();            
            }            
            
        }
        public static void prendercarro()
        {
            if (carrodepaseo.encendido == true)
            {
                Console.WriteLine("su carro esta encendido no se puede volver a encender");
            }
            else
            {
                carrodepaseo.encendido = true;
                Console.WriteLine("su carro esta encendido");
            }
        }
        public static void acelerar()
        {
            Console.Write("En cuanto va acelarar en kilomentros por hora\n");
            Console.Write("1. Primera\n2. Segunda\n3. Tercera\n4. Cuarta\n5. Quinta\n");
            carrodepaseo.cambio = int.Parse(Console.ReadLine());

            switch (carrodepaseo.cambio)
            {
                case 1:
                    carrodepaseo.velocidad = carrodepaseo.velocidad + 15;
                    carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida + 20;
                    if (carrodepaseo.velocidad >= carrodepaseo.velocidadmaxima)
                    {
                        carrodepaseo.velocidad = carrodepaseo.velocidadmaxima;
                        Console.WriteLine("El carro esta en su velocidad máxima " + carrodepaseo.velocidadmaxima + "Kilometros por hora");
                    }
                    else if (carrodepaseo.distanciarecorrida >= 50)
                    {
                        carrodepaseo.galones = carrodepaseo.galones - 3;
                        {
                            Console.WriteLine("su carro se quedo sin gasolina y se va a apagar");
                        }
                    }
                    else
                    {
                        Console.WriteLine("su carro esta andando exitosamente");
                    }
                    break;
                case 2:
                    carrodepaseo.velocidad = carrodepaseo.velocidad + 35;
                    carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida + 45;
                    if (carrodepaseo.velocidad >= carrodepaseo.velocidadmaxima)
                    {
                        carrodepaseo.velocidad = carrodepaseo.velocidadmaxima;
                        Console.WriteLine("El carro esta en su velocidad máxima " + carrodepaseo.velocidadmaxima + "Kilometros por hora");
                    }
                    else if (carrodepaseo.distanciarecorrida >= 50)
                    {
                        carrodepaseo.galones = carrodepaseo.galones - 3;
                        {
                            Console.WriteLine("su carro se quedo sin gasolina y se va a apagar");
                        }
                    }
                    else
                    {
                        Console.WriteLine("su carro esta andando exitosamente");
                    }
                    break;
                case 3:
                    carrodepaseo.velocidad = carrodepaseo.velocidad + 50;
                    carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida + 40;
                    if (carrodepaseo.velocidad >= carrodepaseo.velocidadmaxima)
                    {
                        carrodepaseo.velocidad = carrodepaseo.velocidadmaxima;
                        Console.WriteLine("El carro esta en su velocidad máxima " + carrodepaseo.velocidadmaxima + "Kilometros por hora");
                    }
                    else if (carrodepaseo.distanciarecorrida >= 50)
                    {
                        carrodepaseo.galones = carrodepaseo.galones - 3;
                        {
                            Console.WriteLine("su carro se quedo sin gasolina y se va a apagar");
                        }
                    }
                    else
                    {
                        Console.WriteLine("su carro esta andando exitosamente");
                    }
                    break;
                case 4:
                    carrodepaseo.velocidad = carrodepaseo.velocidad + 155;
                    carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida + 80;
                    if (carrodepaseo.velocidad >= carrodepaseo.velocidadmaxima)
                    {
                        carrodepaseo.velocidad = carrodepaseo.velocidadmaxima;
                        Console.WriteLine("El carro esta en su velocidad máxima " + carrodepaseo.velocidadmaxima + "Kilometros por hora");
                    }
                    else if (carrodepaseo.distanciarecorrida >= 50)
                    {
                        carrodepaseo.galones = carrodepaseo.galones - 3;
                        {
                            Console.WriteLine("su carro se quedo sin gasolina y se va a apagar");
                        }
                    }
                    else
                    {
                        Console.WriteLine("su carro esta andando exitosamente");
                    }
                    break;
                case 5:
                    carrodepaseo.velocidad = carrodepaseo.velocidad + 100;
                    carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida + 90;
                    if (carrodepaseo.velocidad >= carrodepaseo.velocidadmaxima)
                    {
                        carrodepaseo.velocidad = carrodepaseo.velocidadmaxima;
                        Console.WriteLine("El carro esta en su velocidad máxima " + carrodepaseo.velocidadmaxima + "Kilometros por hora");
                    }
                    else if (carrodepaseo.distanciarecorrida >= 50)
                    {
                        carrodepaseo.galones = carrodepaseo.galones - 3;
                        {
                            Console.WriteLine("su carro se quedo sin gasolina y se va a apagar");
                        }
                    }
                    else
                    {
                        Console.WriteLine("su carro esta andando exitosamente");
                    }
                    break;
            }

        }

    }

}



