namespace dotnet___poo.src.Entity
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string heroType;

        public Hero()
        {
            
        }

        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.heroType = heroType;
        }

        
        public override String ToString(){
            return this.Name + " " + this.Level + " " + this.heroType;
        }

        public string Attack(){
            return this.Name + " Atacou com sua espada";
        }
    }
}