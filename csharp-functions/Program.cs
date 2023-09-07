﻿using System.Xml.Linq;
using System;

namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Inizio Programma *****");

            bool keepPlaying = true;
            do
            {
                Console.WriteLine(" ----- Menù ------ ");
                Console.WriteLine(" 1. Base");
                Console.WriteLine(" 2. Bonus");
                Console.WriteLine(" 3. Exit");
                Console.WriteLine(" ----------------- ");

                bool validUserInput = true;
                string userChoice;
                do
                {
                    Console.Write("Scrivi il numero per scegliere cosa eseguire: ");

                     userChoice = Console.ReadLine();

                    if(userChoice == null)
                    {
                        Console.WriteLine("Inserisci un comando.");
                        validUserInput = false;
                    }

                } while (!validUserInput);

                switch (userChoice)
                {
                    case ("1"):
                        {
                            int[] myArray = { 2, 6, 7, 5, 3, 9 };

                            //Stampare l’array di numeri fornito a video
                            Console.Write("Stampo l'array iniziale: ");
                            PrintArray(myArray);

                            //Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato
                            Console.Write("Stampo l'array con i numeri elevati al quadrato: ");
                            PrintArray(SquareArrayElements(myArray));
                            Console.Write("Ristampo l'array originale, verifico che non è stato modificato: ");
                            PrintArray(myArray);

                            //Stampare la somma di tutti i numeri
                            Console.WriteLine($"La somma dei numeri dell'array è : {SumArrayElements(myArray)}.");

                            //Stampare la somma di tutti i numeri elevati al quadrati
                            Console.WriteLine($"La somma dei numeri dell'array dopo aver elevato al quadrato: {SumArrayElements(SquareArrayElements(myArray))}.");
                            break;
                        }
                    case "2":
                        {
                            int arrayLength;
                            bool isLengthValid = true;

                            do
                            {
                                Console.Write("Scegli la lunghezza dell'array. ");
                                arrayLength = getIntFromUser();

                                if( arrayLength <= 0 )
                                {
                                    Console.WriteLine("Digita una lunghezza valida!");
                                    isLengthValid = false;
                                }
                                else
                                {
                                    isLengthValid = true;
                                }

                            } while (!isLengthValid);

                            int[] myArray = new int[arrayLength];

                            for (int i = 0; i < arrayLength; i++)
                            {
                                Console.Write($"Scegli il {i+1}° elemento. ");
                                myArray[i] = getIntFromUser();
                            }

                            //Stampare l’array di numeri fornito a video
                            Console.Write("Stampo l'array iniziale: ");
                            PrintArray(myArray);

                            //Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato
                            Console.Write("Stampo l'array con i numeri elevati al quadrato: ");
                            PrintArray(SquareArrayElements(myArray));
                            Console.Write("Ristampo l'array originale, verifico che non è stato modificato: ");
                            PrintArray(myArray);

                            //Stampare la somma di tutti i numeri
                            Console.WriteLine($"La somma dei numeri dell'array è : {SumArrayElements(myArray)}.");

                            //Stampare la somma di tutti i numeri elevati al quadrati
                            Console.WriteLine($"La somma dei numeri dell'array dopo aver elevato al quadrato: {SumArrayElements(SquareArrayElements(myArray))}.");

                            break;
                        }
                    case "3":
                        {
                            keepPlaying = false;
                            Console.WriteLine("Alla prossima!");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Comando non riconosciuto.");
                            break;
                        }
                }

            } while (keepPlaying);

        }

        // FUNCTIONS

        // function that taken an array of integers, prints on screen the contents of the array
        static void PrintArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" {array[i]}");
                if (i < array.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine(" ]");
        }

        // function that taken an array of strings, prints on screen the contents of the array
        static void PrintArray(string[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($" \"{array[i]}\"");
                if (i < array.Length - 1)
                {
                    Console.Write(",");
                }
            }
            Console.WriteLine(" ]");
        }

        // function that taken an integer releases the number squared
        static int Square(int numero)
        {
            return numero * numero;
        }

        // function that taken an array of integers releases an array copy squared
        static int[] SquareArrayElements(int[] array)
        {
            int[] squaredArray = new int[array.Length];

            for (int i = 0;i < squaredArray.Length;i++)
            {
                squaredArray[i] = Square(array[i]);
            }

            return squaredArray;
        }

        // function that taken an array of integers releases the sum of the integers

        static int SumArrayElements(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length ; i++)
            {
                sum += array[i];
            }

            return sum;

        }

        // function to get an integer number from user
        static int getIntFromUser()
        {
            int userNumber;
            bool validInput = true;
            do
            {
                Console.Write("Digita un numero intero: ");
                validInput = int.TryParse(Console.ReadLine(), out userNumber);
                if (!validInput)
                    Console.WriteLine("Digita un numero valido.");

            } while (!validInput);

            return userNumber;
        }
    }
}