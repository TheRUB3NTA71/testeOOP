public class Mamifero : Animal
{
    public Mamifero(string nome, int idade) : base(nome, idade) { }

    
}
public class Leão : Mamifero{

    public Leão (string nome, int idade) : base(nome, idade){

        Leão = TamanhoDoGrupo;
    }

    public override string EmitirSom(){

        return "roarrrrr";
    }
}
