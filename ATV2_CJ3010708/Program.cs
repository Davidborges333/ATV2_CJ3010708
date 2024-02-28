namespace ATV2_CJ3010708
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario;
            //Leitura do salário
            Console.WriteLine("Entre com o seu salário");
            salario = float.Parse(Console.ReadLine());

            salario = salario + (25.0f/ 100.0f) * salario;

            Console.WriteLine("O novo salário é R${0}", salario);
            Console.ReadKey();
        
        }
    }
}
