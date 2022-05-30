public class WhiteWizard : Hero
{
    public WhiteWizard(string name, int level, string heroType) : base(name, level, heroType)
    {
        this.name = name;
        this.level = level;
        this.heroType = heroType;
    }


    public override string Attack()
    {
        return $"{this.name} lançou magia de Luz!";
    }

    public string Defense(){
        return $"{this.name} defendeu o ataque. Defesa ATIVADA: Barreira de Luz";
    }
    
    public string Attack(int Bonus)
    {

        if (Bonus > 6)
            return $"{this.name} Lançou Magia super EFETIVA com bonus de ataque de: {Bonus}";

        else
            return $"{this.name} Lançou Magia com força FRACA com bonus de ataque de: {Bonus}";

    }
}