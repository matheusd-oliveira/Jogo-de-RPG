public class Knight : Hero
{

    public Knight(string name, int level, string heroType, int hpPoints, int mpPoints) : base(name, level, heroType, hpPoints, mpPoints)
    {
        this.name = name;
        this.level = level;
        this.heroType = heroType;
        this.hpPoints = hpPoints;
        this.mpPoints = mpPoints;
    }

    public override string Attack()
    {

        return $"{this.name} atacou com sua Espada Flamejante.";
    }

    public string Defense()
    {
        return $"{this.name} defendeu o Ataque . Defesa ATIVADA : Escudo de Diamante";
    }

}