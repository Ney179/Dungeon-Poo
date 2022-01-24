namespace dotnet___poo.src.Entity
{
    public class Wizzard : Hero
    {

        public Wizzard(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.heroType = heroType;
        }

        public virtual string Attack(){
            return this.Name + " Lançou magia";
        }

        public string Attack(int Bonus){
            if(Bonus > 6){
                return this.Name + " Lançou magia super efetiva com bonus de ataque de " + Bonus;
            }else{
                return this.Name + " Lançou uma magia com força fraca com bonus de " + Bonus;
            }
        }
    }
}