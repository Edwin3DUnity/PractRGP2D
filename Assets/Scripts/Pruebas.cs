using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Pruebas : MonoBehaviour
{

    public int x = 2;
    public int y = 3;
    public string name = "Edwin Paniagua";

    private int puntaje =(int) 9.5334f;
    
    //int[] lifes = new int[3];
    private int[] lifes = { 2, 3, 4 };

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


        for (int i = 0; i < nombresPersonajes.Count; i++)
        {
            Debug.LogFormat("Nombre pesonaje en la posicion {0} - {1} ", i , nombresPersonajes[i]);
        }

        for (int i = 0; i < lifes.Length; i++)
        {
            Debug.LogFormat("cantidades de vida {0} {1}",i ,lifes[i]);
        }

        for (int i = 0; i < nombresPersonajes.Count; i++)
        {
            string personajeActual = nombresPersonajes[i];

            if (personajeActual == "Bertha")
            {
                Debug.LogFormat("Es el personaje del año {0}", personajeActual);
                
            }
        }

        bool encontrado = false;
        for (int i = 0; i < nombresPersonajes.Count && !encontrado; i ++)
        {
            string personajeActual = nombresPersonajes[i];

            if (personajeActual == "Edwin")
            {
                encontrado = true;
                Debug.LogFormat("Esta persona es la mas luchadora del mundo {0} ", personajeActual);
            }
            if (encontrado)
            {
                
            
                Debug.LogFormat("{0} No te rindas por mas grande que sea el obstaculo",
                   personajeActual);
            }
            else
            {
                Debug.LogFormat("aun puedes");
            }
            Debug.Log(encontrado? "He encontrado a Edwin " : " Aún no aparece");
        }



        foreach (string nombres in nombresPersonajes)
        {
            Debug.Log(nombres + " Presente");
        }


        foreach (int vida in lifes)
        {
         Debug.Log(" Tengo tantas vidas = " + vida);  
        }


        foreach (KeyValuePair<string, int> kvp in armas)
        {
            Debug.LogFormat("Arma : {0} - cantidad: {1} ", kvp.Key, kvp.Value);
        }

        string item = "";
        foreach ( KeyValuePair<string, int> kvp  in armas)
        {
            //Debug.LogFormat("Arma : {0} - {1} ", kvp.Key, kvp.Value);
            if (!armas.ContainsKey(item) || armas[item] < kvp.Value)
            {
                item = kvp.Key;
                
            }
            
            
        }
        Debug.LogFormat("El arma con mas elementos es : {0} que tiene : {1} ", item ,armas[item] );
        
        
        int numberOfLives = 3;
        while (numberOfLives > 0)
        
        {
            Debug.Log("Aun tengo vidas");
            numberOfLives--;
        }
        Debug.Log("ME he quedado sin vidas");
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