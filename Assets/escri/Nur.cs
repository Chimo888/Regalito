using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nur : MonoBehaviour
{
    void Update()
    {
        if (FindObjectOfType<Manageronimo>().ProtogemasTengoNumero == 4)
        {

            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<Animator>().enabled = true;
            GetComponent<AudioSource>().enabled = true;


            Destroy(gameObject, 6.0f);
        }
    }
}
