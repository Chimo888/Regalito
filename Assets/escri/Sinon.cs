using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sinon : MonoBehaviour
{ 
    
    void Update()
    {
        if (FindObjectOfType<Manageronimo>().ProtogemasTengoNumero == 1)
        {

            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<Animator>().enabled = true;
            GetComponent<AudioSource>().enabled = true;
           

            Destroy(gameObject, 5.0f);
        }
    }
}
