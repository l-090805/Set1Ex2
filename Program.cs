namespace Set1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdu primul numar: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Intodu al 2-lea numar: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introdu al 3-lea numar: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double x, x1, x2;
            double delta = (b * b) - (4 * a * c);
            char i = 'i';
            if(delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine($"Ecuatia {a}x^2+{b}x+{c}=0 are 2 solutii reale diferite: x1={x1}, x2={x2}");
            }
            else if( delta == 0 )
            {
                x = -b/2 * a;
                Console.WriteLine($"Ecuatia {a}x^2+{b}x+{c}=0 are 2 solutii reale egale: x1=x2={x}");
            }
            else
            {
                Console.WriteLine($"Ecuatia {a}x^2+{b}x+{c}=0 nu are solutii reale");
            }
        }
    }
}
