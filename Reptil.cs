public class Reptil : Animal
{
    public Reptil(string nome, int idade) : base(nome, idade) { }
}
public class Cobra : Reptil{

     public Cobra (string nome, int idade) : base(nome, idade){

        Cobra = Comprimento;
    }public override string EmitirSom(){

        return "shshhs";
    }
}