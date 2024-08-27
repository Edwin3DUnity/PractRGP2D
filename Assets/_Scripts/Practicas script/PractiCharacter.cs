using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PractiCharacter : MonoBehaviour
{
  private GameObject luzEscena;
  
  
  
  
  
    Character hero = new Character();

    private Paladin p = new Paladin();
    private Weapon martillo = new Weapon("Martillo de rayo", 10);

    public Weapon VaraMajica = new Weapon("Vara con poderes increibles", 60);
    

    public Weapon arch3 = new Weapon("Arco dorado", 20);

    private Transform theTransform;
    // Start is called before the first frame update
    void Start()
    {
      luzEscena = GameObject.Find("Directional Light");

      Transform luz = luzEscena.GetComponent<Transform>();
      Debug.LogFormat("La luz esta en la posicion {0} ", luz);
      
      theTransform = GetComponent<Transform>();
      Debug.LogFormat(" la posicion de  este objeto es {0} ", theTransform.position);
      //  hero.name = "Edwin";
        int nivelPersonaje = hero.level;
      //   Debug.LogFormat("Mi primer personaje se llama {0}, con un nivel de poder de {1} ", hero.name, hero.level );
      hero.PrintCharacterStatus();
      Weapon sword = new Weapon("Espada de Colombia ", 5);
        sword.PrintWeaponStatus();
      Paladin p2 = new Paladin("Juan Gabriel" , martillo);
      p2.PrintCharacterStatus();
        
     Archer archer1 = new Archer("james", arch3);

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
     Magician magician1 = new Magician("ED");
      
         Character heroina = new Character("Carolina");
         //Debug.LogFormat(" Hasta el momento tenemos dos personajes {0} con nivel {1} y {2} con nivel {3} " ,
         //hero.name, hero.level, heroina.name, hero.level );
         heroina.PrintCharacterStatus();
      p2.PrintCharacterStatus();
      archer1.PrintCharacterStatus();
      magician1.PrintCharacterStatus();


      List<Character> party = new List<Character>();
      party.Add(p);
      party.Add(p2);
      party.Add(archer1);
      party.Add(hero2);
      party.Add(magician1);


      foreach (Character pers in party)
      {
        pers.PrintCharacterStatus();
      }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
