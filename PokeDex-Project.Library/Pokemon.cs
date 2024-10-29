namespace PokeDex_Project.Library;

public class PokeDex
{

    public List<Pokemon> PokeData { get; set; } = [];
    public PokeDex()
    {

        PokeData.Add(new Pokemon(14, "Kakuna", "Bug", "Poison", 205, 45, 25));
        PokeData.Add(new Pokemon(15, "Beedrill", "Bug", "Poison", 395, 65, 90));
        PokeData.Add(new Pokemon(16, "Pidgey", "Normal", "Flying", 251, 40, 45));
        PokeData.Add(new Pokemon(19, "Rattata", "Normal", "", 253, 30, 56));
        PokeData.Add(new Pokemon(34, "Nidoking", "Poison", "Ground", 505, 81, 102));
        PokeData.Add(new Pokemon(35, "Clefairy", "Fairy", "", 323, 70, 45));
        PokeData.Add(new Pokemon(57, "Primeape", "Fighting", "", 455, 65, 105));
        PokeData.Add(new Pokemon(58, "Growlithe", "Fire", "", 350, 55, 70));
        PokeData.Add(new Pokemon(72, "Tentacool", "Water", "Poison", 335, 40, 40));
        PokeData.Add(new Pokemon(73, "Tentacruel", "Water", "Poison", 515, 80, 70));
        PokeData.Add(new Pokemon(74, "Geodude", "Rock", "Ground", 300, 40, 80));
        PokeData.Add(new Pokemon(80, "Slowbro", "Water", "Psychic", 490, 95, 75));
    }

    public IEnumerable<Pokemon> SelectHitPoints(int? HitPoints)
    {
        IEnumerable<Pokemon> data = from pokemon in PokeData
                                    orderby pokemon.HitPoints descending
                                    where pokemon.HitPoints > HitPoints
                                    select pokemon;
        return data;
    }

}

public class Table
{
    private List<TableAttributes> TableAttributes { get; set; } = [];

    Table()
    {
        TableAttributes.Add(new TableAttributes("ID", 3));
    }
    public void DisplayHeader() { }
}

public record TableAttributes
{
    public int Offset { get; set; }
    public string Category { get; set; }

    public TableAttributes(string category, int offset)
    {
        Offset = offset;
        Category = category;
    }
}


public record Pokemon(
  int Id,
  string Name,
  string Type1,
  string Type2,
  int HitPoints,
  int Attack,
  int Defense
);
