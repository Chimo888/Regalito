using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensajes : MonoBehaviour
{



    private void Update()
    {

        if (FindObjectOfType<Manageronimo>().ProtogemasTengoNumero == 1)
        {
           
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            GetComponent<AudioSource>().enabled = true;
            

            Destroy(gameObject, 5.0f);
        }

        if (FindObjectOfType<Manageronimo>().ProtogemasTengoNumero == 2)
        {

            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            GetComponent<AudioSource>().enabled = true;


            Destroy(gameObject, 5.0f);
        }

    }
}
