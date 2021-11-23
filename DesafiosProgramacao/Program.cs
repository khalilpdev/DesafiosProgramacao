// See https://aka.ms/new-console-template for more information

//https://youtu.be/zf_fURAQc6Q?t=525
// Criar piramide do mario

string qtdLinhasStr = "";
int qtdLinhas;

LerDados();
while (qtdLinhas < 3 || qtdLinhas > 8)
    LerDados();

Console.WriteLine("Piramide alinhada a esquerda");
for (int i = 1; i <= qtdLinhas; i++)
{
    Console.WriteLine(new string('#', i));
}

Console.WriteLine();
Console.WriteLine("Piramide alinhada a direita");
for (int i = 1; i <= qtdLinhas; i++)
{
    var texto = new string(' ', i) + new string('#', i);
    Console.WriteLine(texto);
}

void LerDados()
{
    Console.Write("Digite o numero de linhas da piramide (de 3 a 8): ");
    qtdLinhasStr = Console.ReadLine();
    int.TryParse(qtdLinhasStr, out qtdLinhas);
}