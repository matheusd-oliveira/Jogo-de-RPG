public class BlackWizard : Hero
{
    public BlackWizard(string name, int level, string heroType) : base(name, level, heroType)
    {
        this.name = name;
        this.level = level;
        this.heroType = heroType;
    }

    public override string Attack()
    {

        return $"{this.name} atacou com sua Magia das Trevas.";
    }

    public string Defense()
    {
        return $"{this.name} defendeu o Ataque . Defesa ATIVADA : Buraco Negro";
    }

}