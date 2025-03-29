using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

class Pasajes
    {
        static void Main(string[] args)
        { 
           Rutas r = new Rutas(215, 155, 190, 160);
           Random random= new Random();
           Random random2 = new Random();
           int equis2 = random2.Next(5, 20);
           int equis = random.Next(5, 20);
           Costo c = new Costo();
          
            
            


            Console.WriteLine("Bienvenido a Caribe Tours Santo Domingo!");
            Console.WriteLine("Elija su destino con el número que corresponda\nEstos son los destinos disponibles para hoy: \n1. Puerto Plata\n2. Santiago\n3. Punta Cana\n4. Samaná");
            int el = Convert.ToInt32(Console.ReadLine());
            
            if (el == 1)
            {
                Console.WriteLine("Cuántos pasajeros quiere abarcar? (Limite cinco personas)");
                var num = Convert.ToInt32(Console.ReadLine());
                var l =  1 == num ? "pasajero" : "pasajeros";
                if (num == 1)
                {
                c.rutitas();

                c.rutitas2();
                }
                else if (num == 2)
                {
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                }
                
                else if (num == 3)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();



                }
                else if (num == 4)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();


                }
                else if (num == 5)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();


                }
            

                Console.WriteLine($"Estos son los autobuses disponibles hasta el momento:\nAutobus Platino {num} {l} Ventas {c.v} quedan {equis} asientos disponibles. \nAutobus Gold {num} {l} Ventas {c.ce} quedan {equis2} asientos disponibles.");
                Console.WriteLine("Para pagar deposite a esta cuenta= Cuenta 0292929\nMuchas gracias!");
                Console.ReadKey();
            }
            else if (el == 2)
            {
                Console.WriteLine("Cuántos pasajeros quiere abarcar? (Limite cinco personas)");
                var num = Convert.ToInt32(Console.ReadLine());
                var l =  1 == num ? "pasajero" : "pasajeros";

                if (num == 1)
                {
                c.rutitas();

                c.rutitas2();
                }
                else if (num == 2)
                {
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                }
                
                else if (num == 3)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();



                }
                else if (num == 4)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();


                }
                else if (num == 5)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                

                }
            
            
            

                Console.WriteLine($"Estos son los autobuses disponibles hasta el momento:\nAutobus Platino {num} {l} Ventas {c.v} quedan {equis} asientos disponibles \nAutobus Gold {num} {l} Ventas {c.ce} quedan {equis2} asientos disponibles.");
                Console.WriteLine("Para pagar deposite a esta cuenta= Cuenta 0292929\nMuchas gracias!");
                Console.ReadKey();
                
         


        }
         else if (el == 3)
            {
                Console.WriteLine("Cuántos pasajeros quiere abarcar? (Limite cinco personas)");
                var num = Convert.ToInt32(Console.ReadLine());
                var l =  1 == num ? "pasajero" : "pasajeros";
               if (num == 1)
                {
                c.rutitas();

                c.rutitas2();
                }
                else if (num == 2)
                {
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                }
                
                else if (num == 3)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();



                }
                else if (num == 4)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();


                }
                else if (num == 5)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                

                }
            
            
            

                Console.WriteLine($"Estos son los autobuses disponibles hasta el momento:\nAutobus Platino {num} {l} Ventas {c.v} quedan {equis} asientos disponibles \nAutobus Gold {num} {l} Ventas {c.ce} quedan {equis2} asientos disponibles.");
                Console.WriteLine("Para pagar deposite a esta cuenta= Cuenta 0292929\nMuchas gracias!");
                Console.ReadKey();
            }

        else if (el == 4)
            {
                Console.WriteLine("Cuántos pasajeros quiere abarcar? (Limite cinco personas)");
                var num = Convert.ToInt32(Console.ReadLine());
                var l =  1 == num ? "pasajero" : "pasajeros";
                if (num == 1)
                {
                c.rutitas();

                c.rutitas2();
                }
                else if (num == 2)
                {
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                }
                
                else if (num == 3)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();



                }
                else if (num == 4)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();


                }
                else if (num == 5)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                

                }
            
            
            

                Console.WriteLine($"Estos son los autobuses disponibles hasta el momento:\nAutobus Platino {num} {l} Ventas {c.v} quedan {equis} asientos disponibles \nAutobus Gold {num} {l} Ventas {c.ce} quedan {equis2} asientos disponibles.");
                Console.WriteLine("Para pagar deposite a esta cuenta= Cuenta 0292929\nMuchas gracias!");
                Console.ReadKey();
            }
            else if (el == 5)
            {
                Console.WriteLine("Cuántos pasajeros quiere abarcar? (Limite cinco personas)");
                var num = Convert.ToInt32(Console.ReadLine());
                var l =  1 == num ? "pasajero" : "pasajeros";
                if (num == 1)
                {
                c.rutitas();

                c.rutitas2();
                }
                else if (num == 2)
                {
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                }
                
                else if (num == 3)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();



                }
                else if (num == 4)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();


                }
                else if (num == 5)
                {
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();
                c.rutitas();

                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                c.rutitas2();
                

                }
            
            

                Console.WriteLine($"Estos son los autobuses disponibles hasta el momento:\nAutobus Platino {num} {l} Ventas {c.v} quedan {equis} asientos disponibles \nAutobus Gold {num} {l} Ventas {c.ce} quedan {equis2} asientos disponibles.");
                Console.WriteLine("Para pagar deposite a esta cuenta= Cuenta 0292929\nMuchas gracias!");
            }
            }
        }
        
    
    
    
       
        