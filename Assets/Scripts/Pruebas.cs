using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Pruebas : MonoBehaviour
{

    public int x = 2;
    public int y = 3;
    public string name = "Edwin Paniagua";

    private int puntaje =(int) 9.5334f;
    
    //int[] lifes = new int[3];
    private int[] lifes = { 1, 2, 3 };

    private List<string> nombresPersonajes = new List<string>()
    {
        "Edwin", "Catalina" , "Leidy"
    };


    private Dictionary<string, int> armas = new Dictionary<string, int>()
    {
        {"Pistola", 5} , {"Rifle", 10}, {"Shangon ", 5}
        
    };
    void Start()
    {
        int firstLive = lifes[0];
        Debug.Log("Primer vida" + firstLive);

        lifes[2] = 5;
        Debug.Log("cantidad de vidas en la opcion 3= " + lifes[2]);

        int tamañoArray = lifes.Length;
        Debug.Log("Opciones de vidas " + tamañoArray);

        int live = 2;
        if(live >= 0 && live < lifes.Length)
        {
            int cantidadLives = lifes[live];
            Debug.Log("modificado " + cantidadLives);

        }

        string personaje1 = nombresPersonajes[0];
        Debug.Log("primer personajes  " +personaje1);
        Debug.LogFormat("Cantidad de personajes {0} " , nombresPersonajes.Count);
        
        nombresPersonajes.Add("Bertha");
        nombresPersonajes.Add("James");
        nombresPersonajes.Add("Andres");
        nombresPersonajes.Add("David");
        Debug.Log("Personajes " + nombresPersonajes.Count);

        nombresPersonajes.Remove("Andres");
        nombresPersonajes.RemoveAt(5);
        
        Debug.Log("personaje" + nombresPersonajes[4]);
        
        nombresPersonajes.Insert(0,"Paola");
        Debug.Log("Personaje " + nombresPersonajes[0]);
        
        Debug.LogFormat(" cantidad de armas {0} " , armas.Count);

        armas["Pistola"] = 8;
        armas["Franco   "] = 7;


        if (armas.ContainsKey("Pistola"))
        {
            armas["Pistola"] -= 1;
            if (armas["Pistola"] == 0)
            {
                armas.Remove("Pistola");
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        switch (y )
        {
            case 1 :
                Debug.Log("Ataque personaje");
                break;
            case 5 :
                Debug.Log("Personaje detenido");
                break;
            case 8 :
                Debug.Log("saltar");
                break;
            
            default:
                Debug.Log("Muerto de miedo");
                break;
                    
                
                
            
        }
    }

    public void SumarDosNumeros()
    {
  
    }
}