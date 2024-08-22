using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class PractiPrograAvan : MonoBehaviour, InterfacePract
{
    // Start is called before the first frame update
    //const
    public const float PI = 3.1416926f;
    
    // solo lectura
    public readonly int numbuerOfEnemies;

    private string _state;

    /*Implementacion de la Interface Imanager*/
    public string State
    {
        get
        {
            
            return _state;
        }
        set
        {
            _state = value;
        }
    }

    /*Implementacion de la Interface Imanager*/
   public  void Initialize()
   {
       _state = "Manager Inicializado";
       Debug.Log(_state);
   }
   
   /*fin de la Interface Imanager*/
    PractiPrograAvan()
    {
        numbuerOfEnemies = 5;
        Utilities.RestarLevel(1);
    }

    public bool AttackEnemy(int damage)
    {
        return true;
        
    }

    public bool AttackEnemy(string name)
    {
        return false;
    }

    public int AttackEnemy(string vidas, int cantidadVidas)
    {
        return cantidadVidas;
    }

    public void AttackEnemy()
    {
        
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
