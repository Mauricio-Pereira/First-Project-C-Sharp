// See https://aka.ms/new-console-template for more information

using IniandoComEntityFramework;
using Console = System.Console;Console.WriteLine("Sistema Iniciando...");

using(var context = new JogosDbContext())
{
    context.Database.EnsureCreated();
    foreach (var jogo in context.JOGOS)
    {
        Console.WriteLine(jogo.NOME + " | " + jogo.DISTRIBUIDORA);
        foreach (var dlc in context.DLC)
        {
            Console.WriteLine(dlc.NOME);
        }
    }
}