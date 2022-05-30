public class Ninja : Hero
{

    public Ninja(string name, int level, string heroType) : base(name, level, heroType)
    {
        this.name = name;
        this.level = level;
        this.heroType = heroType;
    }
}