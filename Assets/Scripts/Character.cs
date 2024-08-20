using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;

        
    }

    public void PrintWeaponStatus()
    {
        Debug.LogFormat("Arma: {0} - {1} ", this.name, this.damage);
    }
}
public class Character
{


    public string name;
    public int level = 0;


    public Character()
    {
        name = "Edwin Paniagua";
    }


    public Character(string name)
    {
        this.name = name;
    }


    public Character(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    public void PrintCharacterStatus()
    {
        Debug.LogFormat("Heroe: {0} - {1} level ", this.name, this.level);
    }

    private void ResetCharacter()
    {
        this.name = "";
        this.level = 0;

    }

}

public class Paladin : Character
{
    public Paladin() : base()
    {
        
    }

    public Paladin(string name) : base((name))
    {
        
    }
}

public class Archer : Character
{

    public Archer() : base()
    {
        
    }

    public Archer(string name) : base(name)
    {
        
    }

}

public class Magician : Character
{
    public Magician() : base()
    {
        
    }

    public Magician(string name) : base(name)
    {
        
    }

    public Magician(string name, int level) : base(name,level)
    {
        
    }
    
}