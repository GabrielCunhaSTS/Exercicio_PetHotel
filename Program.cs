string especie, raca, alcunha, pelagem;
int idade;

int limiteEspecie = 18;
int limiteRaca = 19;
int limiteAlcunha = 31;
int limitePelagem = 23;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Bem vindo(a) ao Au Au Resort");
Console.ResetColor();

Console.WriteLine("\nPreencha a ficha a seguir com as informações do seu pet\n");

Console.WriteLine("FICHA:");

Console.Write("Digite a espécie de seu pet: ");
Console.ForegroundColor = ConsoleColor.White;
especie = Console.ReadLine()!.ToUpper();
Console.ResetColor();

Console.Write("Digite a raça de seu pet: ");
Console.ForegroundColor = ConsoleColor.White;
raca = Console.ReadLine()!.ToUpper();
Console.ResetColor();

Console.Write("Digite a alcunha de seu pet: ");
Console.ForegroundColor = ConsoleColor.White;
alcunha = Console.ReadLine()!.ToUpper();
Console.ResetColor();

Console.Write("Digite a idade de seu pet: ");
Console.ForegroundColor = ConsoleColor.White;
while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
{
    Console.ResetColor();
    Console.Write("Idade inválida, Digite um número (positivo). Digite novamente: ");
    Console.ForegroundColor = ConsoleColor.White;
}
Console.ResetColor();

Console.Write("Digite a cor/pelagem de seu pet: ");
Console.ForegroundColor = ConsoleColor.White;
pelagem = Console.ReadLine()!.ToUpper();
Console.ResetColor();

Console.Clear();

especie = especie.Length > limiteEspecie ? especie[..limiteEspecie] : especie.PadLeft(limiteEspecie, '.');
raca = raca.Length > limiteRaca ? raca[..limiteRaca] : raca.PadLeft(limiteRaca, '.');
alcunha = alcunha.Length > limiteAlcunha ? alcunha[..limiteAlcunha] : alcunha.PadLeft(limiteAlcunha, '.');
pelagem = pelagem.Length > limitePelagem ? pelagem[..limitePelagem] : pelagem.PadLeft(limitePelagem, '.');

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("+=========================================================+");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("|               Pet Hotel \"Au Au Resort\"                  |");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("+=========================================================+");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("| Espécie: ");
Console.ForegroundColor = ConsoleColor.White;
Console.Write($"{especie}");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(" | Raça: ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"{raca} |");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("+=========================================================+");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("| Atende pela alcunha de: ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"{alcunha} |");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("| Idade: ");
Console.ForegroundColor = ConsoleColor.White;
Console.Write($"{idade.ToString().PadLeft(2, '0')}");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(" ano(s) | Pelagem/cor: ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"{pelagem} |");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("+=========================================================+");
Console.ResetColor();
