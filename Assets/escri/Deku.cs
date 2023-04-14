using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deku : MonoBehaviour
{
    void Update()
    {
        if (FindObjectOfType<Manageronimo>().ProtogemasTengoNumero == 3)
        {

            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<Animator>().enabled = true;
            GetComponent<AudioSource>().enabled = true;


            Destroy(gameObject, 10.0f);
        }
    }
}
