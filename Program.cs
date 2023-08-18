using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescontoProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do produto:");
            string input = Console.ReadLine();
            Console.WriteLine();

            if (decimal.TryParse(input, out decimal produtoValor)) {
                decimal desconto = produtoValor * 0.6m;
                decimal valorComDesconto = produtoValor - desconto;

                Console.WriteLine($"a) Produto custava: {produtoValor:C}");
                Console.WriteLine($"b) Com o desconto: {valorComDesconto:C}");
                Console.WriteLine($"c) Valor do desconto: {desconto:C}\n");
            }
            else {
                Console.WriteLine("Valor inválido. Certifique-se de dr fornecer um valor numérico válido.\n");
            }

            Console.WriteLine("Pressione Enter para sair...");
            Console.ReadLine();
        }
    }
}
