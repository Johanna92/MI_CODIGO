﻿using System;
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
        static int ultimo_cambio = 0;

        static void Main(string[] args)
        {
            carrodepaseo.velocidadmaxima = 150;
            carrodepaseo.galones = 9;
            carrodepaseo.velocidad = 0;
            carrodepaseo.distanciarecorrida = 0;
            prendercarro();


            while (carrodepaseo.cambio != -1)

            {
                Console.WriteLine("carrodepaseo.galones =" + (carrodepaseo.galones));
                Console.WriteLine("carrodepaseo.velocidad =" + (carrodepaseo.velocidad));
                Console.WriteLine(" carrodepaseo.distanciarecorrida =" + (carrodepaseo.distanciarecorrida));
                acelerar();

            }
        }
        public static void prendercarro()
        {
            if (carrodepaseo.encendido == true)
            {
                Console.WriteLine("su carro esta encendido");
            }
            else
            {
                carrodepaseo.encendido = true;
                Console.WriteLine("No puede volver a encender el carro");
            }
        }
        public static void acelerar()
        {
            Console.Write("Que acción desea hacer con el carro\n");
            Console.Write("1. Acelerar\n2. Frenar\n");
            carrodepaseo.accion = int.Parse(Console.ReadLine());
            if (carrodepaseo.accion != 1 && carrodepaseo.accion != 2)
            {
                Console.WriteLine("su carro solo esta predido");
            }
            Console.Clear();
            if (carrodepaseo.accion == 1)
            {
                Console.Write("En cuanto va acelarar en kilomentros por hora\n");
                Console.Write("1. Primera\n2. Segunda\n3. Tercera\n4. Cuarta\n5. Quinta\n");
                carrodepaseo.cambio = int.Parse(Console.ReadLine());
                switch (carrodepaseo.cambio)
                {
                    case 1:
                        if (ultimo_cambio == 2|| ultimo_cambio == 3 || ultimo_cambio == 4 || ultimo_cambio == 5)
                        {
                            Console.WriteLine("No puede realizar este cambio");
                            return;
                        }
                        if (carrodepaseo.cambio == ultimo_cambio)
                        {
                            Console.WriteLine("su carro esta andando exitosamente");
                            return;
                        }
                        carrodepaseo.velocidad = carrodepaseo.velocidad + 15;
                            carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida + 20;                           
                            if (carrodepaseo.distanciarecorrida >= 50)
                            {
                                carrodepaseo.galones = carrodepaseo.galones - 3;
                                if (carrodepaseo.galones <= 0)
                                {
                                    Console.WriteLine("su carro se quedo sin gasolina y se va a apagar");

                                }
                                else if (carrodepaseo.velocidad >= carrodepaseo.velocidadmaxima)
                                {
                                    Console.WriteLine("El carro esta en su velocidad máxima " + carrodepaseo.velocidadmaxima + "Kilometros por hora");
                                }
                            }
                            else
                            {
                                Console.WriteLine("su carro esta andando exitosamente");
                            }
                        ultimo_cambio = carrodepaseo.cambio;                   
                            break;
                    case 2:
                        if (ultimo_cambio == 3 || ultimo_cambio == 4 || ultimo_cambio == 5)
                        {
                            Console.WriteLine("No puede realizar este cambio");
                            return;
                        }
                        if (carrodepaseo.cambio == ultimo_cambio)
                        {
                            Console.WriteLine("su carro esta andando exitosamente");
                            return;
                        }
                        carrodepaseo.velocidad = carrodepaseo.velocidad + 20;
                            carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida + 25;
                            if (carrodepaseo.distanciarecorrida >= 50)
                            {
                                carrodepaseo.galones = carrodepaseo.galones - 3;
                                if (carrodepaseo.galones <= 0)
                                {
                                    Console.WriteLine("su carro se quedo sin gasolina y se va a apagar");
                                }
                                else if (carrodepaseo.velocidad >= carrodepaseo.velocidadmaxima)
                                {
                                    Console.WriteLine("El carro esta en su velocidad máxima " + carrodepaseo.velocidadmaxima + "Kilometros por hora");
                                }
                            }
                            else
                            {
                                Console.WriteLine("su carro esta andando exitosamente");
                            }                        
                        ultimo_cambio = carrodepaseo.cambio;            
                        break;
                    case 3:
                        if (ultimo_cambio == 4 || ultimo_cambio == 5)
                        {
                            Console.WriteLine("No puede realizar este cambio");
                            return;
                        }
                        if (carrodepaseo.cambio == ultimo_cambio)
                        {
                            Console.WriteLine("su carro esta andando exitosamente");
                            return;
                        }
                        carrodepaseo.velocidad = carrodepaseo.velocidad + 30;
                        carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida + 35;
                        if (carrodepaseo.distanciarecorrida >= 50)
                        {
                            carrodepaseo.galones = carrodepaseo.galones - 3;
                            if (carrodepaseo.galones <= 0)
                            {
                                Console.WriteLine("su carro se quedo sin gasolina y se va a apagar");
                            }
                            else if (carrodepaseo.velocidad >= carrodepaseo.velocidadmaxima)
                            {
                                Console.WriteLine("El carro esta en su velocidad máxima " + carrodepaseo.velocidadmaxima + "Kilometros por hora");
                            }
                            else
                            {
                                Console.WriteLine("su carro esta andando exitosamente");
                            }
                        }
                        else
                        {
                            Console.WriteLine("su carro esta andando exitosamente");
                        }
                        ultimo_cambio = carrodepaseo.cambio;
                        break;
                    case 4:
                        if (ultimo_cambio == 5)
                        {
                            Console.WriteLine("No puede realizar este cambio");
                            return;
                        }                       
                        if (carrodepaseo.cambio == ultimo_cambio)
                        {
                            if (carrodepaseo.velocidad >= carrodepaseo.velocidadmaxima)
                            {
                                Console.WriteLine("El carro esta en su velocidad máxima " + carrodepaseo.velocidadmaxima + "Kilometros por hora");
                            }
                            return;
                        }
                        carrodepaseo.velocidad = carrodepaseo.velocidad + 40;
                        carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida + 55;
                        if (carrodepaseo.distanciarecorrida >= 50)
                        {
                            carrodepaseo.galones = carrodepaseo.galones - 3;
                            if (carrodepaseo.galones <= 0)
                            {
                                Console.WriteLine("su carro se quedo sin gasolina y se va a apagar");
                            }
                            else if (carrodepaseo.velocidad >= carrodepaseo.velocidadmaxima)
                            {
                                Console.WriteLine("El carro esta en su velocidad máxima " + carrodepaseo.velocidadmaxima + "Kilometros por hora");
                            }
                        }
                        else
                        {
                            Console.WriteLine("su carro esta andando exitosamente");
                        }
                        ultimo_cambio = carrodepaseo.cambio;
                        break;
                    case 5:
                        if (carrodepaseo.cambio == ultimo_cambio)
                        {
                            if (carrodepaseo.galones <= 0)
                            {
                                Console.WriteLine("su carro se quedo sin gasolina y se va a apagar");
                            }
                            return;
                        }                        
                        carrodepaseo.velocidad = carrodepaseo.velocidad + 55;
                        carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida + 60;
                        if (carrodepaseo.distanciarecorrida >= 50)
                        {
                            carrodepaseo.galones = carrodepaseo.galones - 3;                           
                            if (carrodepaseo.galones <= 0)
                            {
                                Console.WriteLine("su carro se quedo sin gasolina y se va a apagar");
                            }
                            else if (carrodepaseo.velocidad >= carrodepaseo.velocidadmaxima)
                            {
                                carrodepaseo.velocidad = carrodepaseo.velocidadmaxima;
                                Console.WriteLine("El carro esta en su velocidad máxima " + carrodepaseo.velocidadmaxima + "Kilometros por hora");
                            }
                        }
                        else
                        {
                            Console.WriteLine("su carro esta andando exitosamente");
                        }
                        ultimo_cambio = carrodepaseo.cambio;
                        break;
                }               
            }           
            if (carrodepaseo.cambio == 0)
            {
                Console.WriteLine("solo esta frenando");
                return;
            }           
            if (carrodepaseo.accion == 2)
            {
                Console.Write("En cuanto va a frenar en kilomentros por hora\n");
                Console.Write("1. Primera\n2. Segunda\n3. Tercera\n4. Cuarta\n5. Quinta\n");
                carrodepaseo.freno = int.Parse(Console.ReadLine());

                switch (carrodepaseo.freno)
                {
                    case 1:
                        if (carrodepaseo.cambio == 3 || carrodepaseo.cambio == 4 || carrodepaseo.cambio == 5)
                        {
                            Console.WriteLine("Esta forma de frenar no es correcta su carro sigue en la misma velocidad");
                        }
                        else
                        {
                            carrodepaseo.velocidad = carrodepaseo.velocidad - 15;
                            carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida - 20;
                            if (carrodepaseo.distanciarecorrida == 0)
                            {
                                if (carrodepaseo.galones == 0)
                                {
                                    Console.WriteLine("su carro se esta apagando");
                                }
                                else if (carrodepaseo.velocidad == 0)
                                {
                                    Console.WriteLine("su carro se esta apagando");
                                }
                            }
                            else
                            {
                                Console.WriteLine("su carro esta andando exitosamente");
                            }
                        }
                        break;
                    case 2:
                        if (carrodepaseo.cambio == 1 || carrodepaseo.cambio == 4 || carrodepaseo.cambio == 5)
                        {
                            Console.WriteLine("Esta forma de frenar no es correcta su carro sigue en la misma velocidad");
                        }
                        else
                        {
                            carrodepaseo.velocidad = carrodepaseo.velocidad - 29;
                            carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida - 35;
                            if (carrodepaseo.distanciarecorrida == 0)
                            {
                                if (carrodepaseo.galones == 0)
                                {
                                    Console.WriteLine("su carro se esta apagando");
                                }
                                else if (carrodepaseo.velocidad == 0)
                                {
                                    Console.WriteLine("su carro se esta apagando");
                                }
                            }
                            else
                            {
                                Console.WriteLine("su carro esta andando exitosamente");
                            }
                        }
                        break;
                    case 3:
                        if (carrodepaseo.cambio == 1 || carrodepaseo.cambio == 2 || carrodepaseo.cambio == 5)
                        {
                            Console.WriteLine("Esta forma de frenar no es correcta su carro sigue en la misma velocidad");
                        }
                        else
                        {
                            carrodepaseo.velocidad = carrodepaseo.velocidad - 40;
                            carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida - 55;
                            if (carrodepaseo.distanciarecorrida == 0)
                            {
                                if (carrodepaseo.galones == 0)
                                {
                                    Console.WriteLine("su carro se esta apagando");
                                }
                                else if (carrodepaseo.velocidad == 0)
                                {
                                    Console.WriteLine("su carro se esta apagando");
                                }
                            }
                            else
                            {
                                Console.WriteLine("su carro esta andando exitosamente");
                            }
                        }
                        break;
                    case 4:
                        if (carrodepaseo.cambio == 1 || carrodepaseo.cambio == 2 || carrodepaseo.cambio == 3)
                        {
                            Console.WriteLine("Esta forma de frenar no es correcta su carro sigue en la misma velocidad");
                        }
                        else
                        {
                            carrodepaseo.velocidad = carrodepaseo.velocidad - 50;
                            carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida - 65;
                            if (carrodepaseo.distanciarecorrida == 0)
                            {
                                if (carrodepaseo.galones == 0)
                                {
                                    Console.WriteLine("su carro se esta apagando");
                                }
                                else if (carrodepaseo.velocidad == 0)
                                {
                                    Console.WriteLine("su carro se esta apagando");
                                }
                            }
                            else
                            {
                                Console.WriteLine("su carro esta andando exitosamente");
                            }
                        }
                        break;
                    case 5:
                        if (carrodepaseo.cambio == 1 || carrodepaseo.cambio == 2 || carrodepaseo.cambio == 3 || carrodepaseo.cambio == 5)
                        {
                            Console.WriteLine("Esta forma de frenar no es correcta su carro sigue en la misma velocidad");
                        }
                        else
                        {
                            carrodepaseo.velocidad = carrodepaseo.velocidad - 65;
                            carrodepaseo.distanciarecorrida = carrodepaseo.distanciarecorrida - 85;
                            if (carrodepaseo.distanciarecorrida == 0)
                            {
                                if (carrodepaseo.galones == 0)
                                {
                                    Console.WriteLine("su carro se esta apagando");
                                }
                                else if (carrodepaseo.velocidad == 0)
                                {
                                    Console.WriteLine("su carro se esta apagando");
                                }
                            }
                            else
                            {
                                Console.WriteLine("su carro esta andando exitosamente");
                            }
                        }
                        break;
                        
                }
            }            
        }        
    }    
}










