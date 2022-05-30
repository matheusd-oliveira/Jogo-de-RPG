public class Knight : Hero {

    public Knight(string name, int level, string heroType) : base(name, level, heroType)
    {
        this.name = name;
        this.level = level;
        this.heroType = heroType;
    }

    public override string Attack(){
        
        return $"{this.name} atacou com sua Espada Flamejante.";
    }

    public string Defense(){
        return $"{this.name} defendeu o Ataque . Defesa ATIVADA : Escudo de Diamante";
    }

}