using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruebas : MonoBehaviour
{

    public int x = 2;
    public int y = 3;
    public string name = "Edwin Paniagua";

    private int puntaje =(int) 9.5334f;

    void Start()
    {
        SumarDosNumeros();
        Debug.Log("Hoy es miercoles");
        Debug.Log(x);
        Debug.Log(name);
        
        Debug.LogFormat("El varor de una suma entre  {0} y {1} , da un resultado de {2}", x, y , x + y);
        string puesto = $"Es un de los mejores desarrolladores {name}";
        Debug.Log(puesto);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SumarDosNumeros()
    {
      int resultado =  x + y;
      Debug.Log(resultado);
    }
}