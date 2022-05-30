public class Wizard : Hero
{
    public Wizard(string name, int level, string heroType) : base(name, level, heroType)
    {
        this.name = name;
        this.level = level;
        this.heroType = heroType;
    }


    public override string Attack()
    {
        return $"{this.name} lançou magia!";
    }

    public string Attack(int Bonus) {
        return $"{this.name} Lançou Magia com bonus de ataque de: {Bonus}";
    }
}