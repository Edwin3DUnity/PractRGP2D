using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public static class Utilities
{

    public static int playerDeaths = 0;


    public static void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       // Time.timeScale = 1.0f;
        
        Debug.Log(("Muertes del jugador : " + playerDeaths));
        string message = UpdateDeathCount(ref playerDeaths);
        Debug.Log("Muertes totales; " + playerDeaths);
    }



    public static void RestarLevel(int buildIndex)
    {
//        SceneManager.LoadScene(0);
     //   Time.timeScale = 1;
    }


    public static string UpdateDeathCount(ref int countRef)
    {
        countRef++;
        return "has jugado ya " + countRef + " veces";
    }


}
