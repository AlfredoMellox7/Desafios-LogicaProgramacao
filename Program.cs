public class calculadorRank
{
    public static string CalcularRank(int vitorias, int derrotas)
    {
        int saldo = vitorias - derrotas;

        string rank;
        if (vitorias < 10)
        {
            rank = "Bronze";
        }
        else if (vitorias <= 20)
        {
            rank = "Bronze";
        }
        else if (vitorias <= 50)
        {
            rank = "Prata";
        }
        else if (vitorias <= 80)
        {
            rank = "Ouro";
        }
        else if (vitorias <= 90)
        {
            rank = "Diamante";
        }
        else
        {
            rank = "Lendário";
        }

        return rank;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Seja Bem-Vindo(a) ao Hall dos Campeões\nLugar onde os guerreiros(a) são imortalizados em nossa base de dados xD\nQual o nome do(a) guerreiro(a) que será imortalizado(a) hoje ?");
        string nomeGuerreiro = Convert.ToString(Console.ReadLine()!);
        Console.WriteLine("Magnífico, agora registre quantas vitórias seu guerreiro(a) saiu vitorioso(a) :");
        int vitorias = Convert.ToInt32(Console.ReadLine()!);
        Console.WriteLine("Explêndido, agora registre quantas derrotas seu guerreiro(a) sofreu nos campos de batalha :");
        int derrotas = Convert.ToInt32(Console.ReadLine()!);

        string rank = CalcularRank(vitorias, derrotas);
        Console.WriteLine($"Seu guerreiro tem {vitorias} vitórias bem sucedidas e {derrotas} derrotas no campo de batalha .");
        Console.WriteLine($"O saldo de partidas rankeadas é {vitorias - derrotas}.");
        Console.WriteLine($"O rank do seu guerreiro foi registrado como : {rank} em nosso mural celestial dos Grandes Guerreiros .\nParabéns !");
    }
}