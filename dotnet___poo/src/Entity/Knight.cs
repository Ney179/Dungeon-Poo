namespace dotnet___poo.src.Entity
{
    public class Knight : Hero
    {
         public Knight(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.heroType = heroType;
        }
    }
}