using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalcofre : MonoBehaviour
{

    public int GG = 0;

    private void Update()
    {
        if (FindObjectOfType<Manageronimo>().ProtogemasTengoNumero == 4)
        {
            Invoke("Abrir", 8f);
            Invoke("Tarta", 8f);
            Invoke("Plano", 13f);
            Invoke("AlPutoMenu", 45f);
            
        }
    }

    private void Abrir()
    {
        GetComponent<Animator>().enabled = true;
    }
    private void Cerrar()
    {
        GetComponent<Animator>().enabled = false;
    }
    private void Tarta()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
    }
    private void Plano()
    {
        gameObject.transform.GetChild(1).gameObject.SetActive(true);
        gameObject.transform.GetChild(2).gameObject.SetActive(true);
    }
    private void AlPutoMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
