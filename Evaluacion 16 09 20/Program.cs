using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_16_09_20
{
    class Program
    {
        static void Main(string[] args)
        {

            int opc = 0;
            string salir;
            int salir1;
            Stack pila = new Stack();
            double precio_total = 0;
            int porcent_apli = 0;




            Console.WriteLine("Camisas PRADBIT – Ventas minoristas y mayoristas\n");
            do
            {
                int cant = pila.Count;
                double precio_sin_descuento = cant * 1000;
                if (cant < 4)
                {
                    precio_total = cant * 1000;
                }

                Console.Clear();
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("MENÚ PRINCIPAL:");
                Console.WriteLine("1 - Añadir camisa al carro de compras");
                Console.WriteLine("2 - Eliminar camisa del carro de compras");
                Console.WriteLine("3 - Salir\n");
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("   -Cantidad de camisas en el carro de compras: " + cant);
                Console.WriteLine("   - Precio unitario: $1000   ");
                Console.WriteLine("   - Precio total sin descuento: "+precio_sin_descuento);
                Console.WriteLine("   - Tipo de descuento aplicado: "+ porcent_apli + "%");
                Console.WriteLine("   - Precio final con descuento: "+ precio_total);
                Console.WriteLine("---------------------------------------------------------------------------------------------------");
                Console.WriteLine("Ingrese una opción del menú: ");

                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {

                    case 1:
                        pila.Push(1000);
                        
                        Console.WriteLine("Objeto Añadido Al carrito");

                        if (cant == 3 || cant >= 5){

                            precio_total = precio_sin_descuento - ((precio_sin_descuento / 100)*10);
                            porcent_apli = 10;

                        } if(cant > 5){
                            precio_total = precio_sin_descuento - ((precio_sin_descuento / 100) * 20);
                            porcent_apli = 20;

                        }
                        break;
                    case 2:
                        int valor = 0;
                        valor = (int)pila.Pop();
                        Console.WriteLine("Objeto Eliminado Del carrito");
                        break;
                    case 3:
                        Console.WriteLine("Realmente Deseea Salir... S/N");
                        salir = Console.ReadLine();
                        if (salir == "s" || salir == "S" );
                        {
                            salir1 = 1;
                        }
                        
                        break;
                }


            } while (salir1 != 1);

            Console.ReadKey();

        }

    }
}
