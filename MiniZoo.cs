using System;
using System.Collections.Generic;

public class MiniZoo
{
    private List<Animal> _animais;

    public MiniZoo()
    {
        _animais = new List<Animal>();
    }
     public void AdicionarAnimal(Animal animal){

        _animais.Add(animal);
        
    }
    public void EmitirSomDeTodosOsAnimais(){

        foreach(Animal a in _animais){
            a.EmitirSom();
        }
    }
}

