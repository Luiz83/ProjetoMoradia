using ProjetoMoradia.Models;
namespace ProjetoMoradia;

public class Program
{
    static void Main(string[] args)
    {
        /*Moradia Moradia = new Casa("Rua Campos Bicudo", 08042360, 240, 4, 3, true);
        Moradia.AdicionarMoradores(new Morador("Raimunda Brenda Isadora Santos","74904598261","09/03/1991"));
        Moradia.AdicionarMoradores(new Morador("Allana Priscila Aragão","28999665020","12/03/1963"));
        Moradia.AdicionarMoradores(new Morador("Manuel Victor Baptista","78944588724","01/01/1987"));
        Moradia.AdicionarMoradores(new Morador("Augusto Sérgio Almada","69118437311","20/02/1971"));*/

        Moradia Moradia = new Apartamento("Vila Frei Caneca", 68906465, 120, 3, 3, 8,1000);
        Moradia.AdicionarMoradores(new Morador("Jéssica Camila Bárbara Barbosa","09848955909","24/01/1948"));
        Moradia.AdicionarMoradores(new Morador("Jennifer Nair Nogueira","51380799562","20/04/1986"));
        Moradia.AdicionarMoradores(new Morador("Ruan Pietro Ian Pereira","95139966115","04/01/1962"));

      /*Moradia Moradia = new Kitnet("Avenida Kaytto Guilherme do Nascimento Pinto", 78048240, 40, 1, 1);
        Moradia.AdicionarMoradores(new Morador("Isabelle Marina Tatiane Galvão","46478649792","03/01/1949"));
        Moradia.AdicionarMoradores(new Morador("Augusto Emanuel Felipe Carvalho","65799740440","05/02/1977"));*/

        Console.WriteLine("Digite o cpf de quem vai ser retirado da lista");
        var cpfRetirar = Console.ReadLine();
        Moradia.RemoverMorador(cpfRetirar);
        Console.WriteLine(Moradia.CalcularValor());
        Console.ReadLine();
    }
}
