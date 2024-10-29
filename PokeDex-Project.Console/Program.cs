// See https://aka.ms/new-console-template for more information
using PokeDex_Project.Library;
Console.Clear();
Console.WriteLine($"{"Just another PokeDex!",10}");

PokeDex pokeDex = new();

IEnumerable<Pokemon> pokemonOver300HP = pokeDex.SelectHitPoints(300);

Console.WriteLine($"|{new string('-', 5)}|{new string('-', 17)}|{new string('-', 5)}|{new string('-', 10)}|");
foreach (var pokemon in pokemonOver300HP)
{
    Console.WriteLine($"|{new string('-', 5)}|{new string('-', 17)}|{new string('-', 5)}|{new string('-', 10)}|");
    Console.WriteLine($"| {pokemon.Id,3:000} | {pokemon.Name,-15} | {pokemon.HitPoints,3} | {pokemon.Type1,-8} |");
}
