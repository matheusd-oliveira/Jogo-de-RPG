public abstract class Hero
{

    public string name;
    public int level;
    public string heroType;
    public int hpPoints;
    public int mpPoints;


    public Hero(string name, int level, string heroType, int hpPoints, int mpPoints)
    {
        this.name = name;
        this.level = level;
        this.heroType = heroType;
        this.hpPoints = hpPoints;
        this.mpPoints = mpPoints;
    }

    public override string ToString()
    {

        return $"Hero Name: {this.name} | Level: {this.level} | Hero Type: {this.heroType} | HP Points: {this.hpPoints} | MP Points: {this.mpPoints}";
    }

    public virtual string Attack()
    {
        return $"{this.name} atacou com a sua Espada!";
    }


}