using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void Salir()
    {
        Debug.Log("ya me lo pasé al 101%");
        Application.Quit();
    }

    public void Creditos()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
    }

    public void Volver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }

}
