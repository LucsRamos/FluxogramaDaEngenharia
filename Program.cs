Console.WriteLine("Fluxograma da Engenharia\n");
Console.Write("O objeto está se movendo (S/N)? ");
bool EstaSeMovendo = Console.ReadLine() ! .Trim() .Substring(0, 1) .ToUpper() == "S"; 
Console.Write("Deveria? ");
bool Deveria = Console.ReadLine() ! .Trim() .Substring(0, 1) .ToUpper() == "S";
string mensagem;
if (!EstaSeMovendo)
{
    if (!Deveria)
    {
        mensagem = "Ótimo!";
    }
    else
    {
        mensagem = "Use WD-40.";
    }
}
else
{
    if (Deveria)
    {
        mensagem = "Ótimo!";
    }
    else
    {
        mensagem = "Use silver tape.";
    }
}
Console.WriteLine();
Console.WriteLine(mensagem);