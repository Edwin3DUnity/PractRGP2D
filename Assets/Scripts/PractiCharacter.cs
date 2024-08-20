using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PractiCharacter : MonoBehaviour
{
    Character hero = new Character();

    private Paladin p = new Paladin();

    private Paladin p2 = new Paladin("Juan Gabriel");

    private Archer archer1 = new Archer("james");

    private Magician magician1 = new Magician("ED", 55);
    
    // Start is called before the first frame update
    void Start()
    {
      //  hero.name = "Edwin";
        int nivelPersonaje = hero.level;
      //   Debug.LogFormat("Mi primer personaje se llama {0}, con un nivel de poder de {1} ", hero.name, hero.level );
      hero.PrintCharacterStatus();
      Weapon sword = new Weapon("Espada de Colombia ", 5);
        sword.PrintWeaponStatus();
      
        
        Weapon sword2 = sword;
      sword2.PrintWeaponStatus();
      sword2.name = "acha";
      sword2.PrintWeaponStatus();
      
      sword.PrintWeaponStatus();

      Character hero2 = hero;
      hero2.PrintCharacterStatus();

      hero2.name = "Cata";
      hero2.PrintCharacterStatus();
      hero.PrintCharacterStatus();
      
         Character heroina = new Character("Carolina");
         //Debug.LogFormat(" Hasta el momento tenemos dos personajes {0} con nivel {1} y {2} con nivel {3} " ,
         //hero.name, hero.level, heroina.name, hero.level );
         heroina.PrintCharacterStatus();
      p2.PrintCharacterStatus();
      archer1.PrintCharacterStatus();
      magician1.PrintCharacterStatus();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
