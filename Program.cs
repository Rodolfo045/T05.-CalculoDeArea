using System;

namespace SobreCargaFiguras
{

class Figura
{
   private string nombre;
        private double ladoa;
        private double ladob;


    public string Nombre { get; set; }
        public double Ladoa { get; set; }


        public double Ladob { get; set; }

    }

    class Operaciones
    {
        

        public double CalcularArea(double lado1, double lado2)
        {
            return (lado1 * lado2) ;
        }

        public double CalcularArea(double lado1)
        {
            return (lado1 * lado1);
        }
        

    }


    class Principal
    {
        Figura fig = new Figura();
        Operaciones op = new Operaciones();

        public void Calcular()
        {
            Console.WriteLine("Ingrese el valor de un lado");
            fig.Ladoa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de un lado");
            fig.Ladob = Convert.ToDouble(Console.ReadLine());
            double a;

             a = op.CalcularArea(fig.Ladoa,fig.Ladob);
             Console.WriteLine("El area de la figura es: "+ a.ToString());

        }

        



    }




    class Program
    {
        static void Main(string[] args)
        {
            Principal p = new Principal();
            p.Calcular();
            

            
            
        }
    }
}
