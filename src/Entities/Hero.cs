public abstract class Hero {

    public string name;
    public int level;
    public string  heroType;


    public Hero(string name, int level, string heroType)
    {
        this.name = name;
        this.level = level;
        this.heroType = heroType;
    }

    public override string ToString(){

        return $"Hero Name: {this.name} | Level: {this.level} | Hero Type: {this.heroType}";
    }

    public virtual string Attack(){
        return $"{this.name} atacou com a sua Espada!";
    }
    

}