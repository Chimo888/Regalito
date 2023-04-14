using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscar : MonoBehaviour
{
   

   
    void Update()
    {
        if (FindObjectOfType<Manageronimo>().ProtogemasTengoNumero == 2)
        {

            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<Animator>().enabled = true;
            GetComponent<AudioSource>().enabled = true;


            Destroy(gameObject, 5.0f);
        }
    }
}
