using System;
//Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
//A partir de dichos datos informar:

//a. El mayor de los números pares.
//b. La cantidad de números impares.
//c. El menor de los números primos.

//Nota: evaluar el uso de una función que analice si un número dado es primo o no y que 
//devuelva true o false según corresponda.

namespace TPFinal_DaCosta
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numeros=0,contImpares,MaxPar=0,MinPrimo=0;
            bool BanPares,BanPrimo,Primo,Aux;
        
            PedirDatos(ref Numeros);

            contImpares = 0;
            BanPares = false;
            BanPrimo = false;
            Primo = false;
            Aux = false;

            while (Numeros != 0)
            {
                Aux = ParImpar(Numeros);

                if(Aux){
                
                if(!BanPares){

                    MaxPar = Numeros;
                                                // Punto A
                    BanPares = true;

                }else if (Numeros > MaxPar)
                {
                    MaxPar = Numeros;
                }
                
                } else
                {
                    contImpares++;           // Punto B
                }
                
                Primo = EvaluarPrimo(Numeros);

                if(Primo){

                    if(!BanPrimo){

                    MinPrimo = Numeros;             // Punto C
                    BanPrimo = true;

                    }else if(Numeros < MinPrimo)
                    {
                        MinPrimo = Numeros;
                    }
                }


                PedirDatos(ref Numeros);
            }

            Console.WriteLine("El mayor de los numeros pares es: " +MaxPar);
             Console.WriteLine("La cantidad de numeros impares es de: " +contImpares);
              Console.WriteLine("El menor de los numeros primos es: " +MinPrimo);


            
        }

        static void PedirDatos(ref int j){

            Console.WriteLine("Ingrese un numero por favor: ");
            j = int.Parse(Console.ReadLine());
        }

        static bool ParImpar(int k){

         if(k%2==0){

            return true;
         } else
         {

            return false;
         }

        }

        static bool EvaluarPrimo(int p){

            int Cont = 0;

         for (int i = 1; i <= p; i++)
         {
            if(p%i==0){

                Cont ++;
            }
         }

         if(Cont == 2){

            return true;
         }else
         {
            return false;
         }

        }
    }
}
