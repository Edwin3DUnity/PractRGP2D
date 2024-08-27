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

    public virtual void PrintCharacterStatus()
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
    public Weapon weapon;
    public Paladin() : base()
    {
        
    }

    public Paladin(string name, Weapon weapon) : base((name))
    {
        this.weapon = weapon;
    }

    public override void PrintCharacterStatus()
    {
        Debug.LogFormat("Hola, soy el paladin {0} y llevo una {1} ", this.name, this.weapon.name);
    }
}

public class Archer : Character
{
    public Weapon arch;
    public Archer() : base()
    {
        
    }

    public override void PrintCharacterStatus()
    {
        base.PrintCharacterStatus();
        Debug.LogFormat("llveo una {0} ",this.arch.name );
        
    }

    public Archer(string name, Weapon arch) : base(name)
    {
        this.arch = arch;
    }

}

public class Magician : Character
{
    private Weapon staff;
    public Magician() : base()
    {
        
    }

    public Magician(string name) : base(name)
    {
        
    }

    public Magician(string name, int level) : base(name,level)
    {
        this.staff = new Weapon("Vara magica dorada" , 30);
    }
    
    
    
    
}