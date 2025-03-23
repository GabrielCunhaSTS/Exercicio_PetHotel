string especie, raca, alcunha, pelagem;
int idade;

Console.WriteLine("Bem vindo(a) ao Au Au Resort");

Console.WriteLine("Preencha a ficha a seguir com as informações do seu pet\n");

Console.WriteLine("FICHA:");

Console.Write("Digite a espécie de seu pet: ");
especie = Console.ReadLine()!.ToUpper();

Console.Write("Digite a raça de seu pet: ");
raca = Console.ReadLine()!.ToUpper();;

Console.Write("Digite a alcunha de seu pet: ");
alcunha = Console.ReadLine()!.ToUpper();

Console.Write("Digite a idade de seu pet: ");
 while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
    {
        Console.Write("Idade inválida, Digite um número. Digite novamente: ");
    }
  
Console.Write("Digite a cor/pelagem de seu pet: ");
pelagem = Console.ReadLine()!.ToUpper();

 Console.Clear(); 

Console.WriteLine("+=========================================================+");
Console.WriteLine("|               Pet Hotel \"Au Au Resort\"                  |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| Espécie: {especie,-18} | Raça: {raca,-19} |");
Console.WriteLine("+=========================================================+");
Console.WriteLine($"| Atende pela alcunha de: {alcunha,-31} |");
Console.WriteLine($"| Idade: {idade,-2}ano(s) | Pelagem/cor: {pelagem,-24} |");
Console.WriteLine("+=========================================================+");