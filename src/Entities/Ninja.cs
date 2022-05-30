public class Ninja : Hero
{

    public Ninja(string name, int level, string heroType, int hpPoints, int mpPoints) : base(name, level, heroType, hpPoints, mpPoints)
    {
        this.name = name;
        this.level = level;
        this.heroType = heroType;
        this.hpPoints = hpPoints;
        this.mpPoints = mpPoints;
    }

    public override string Attack()
    {

        return $"{this.name} utilizou sua Furtividade para apunhalar o inimigo.";
    }

    public string Defense()
    {
        return $"{this.name} defendeu o Ataque . Defesa ATIVADA : Camuflagem";
    }

}