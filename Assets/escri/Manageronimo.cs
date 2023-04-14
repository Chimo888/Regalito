using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manageronimo : MonoBehaviour
{
    public Text ProtogemasTengo;

    public Text ProtogemasTotales;

    public int ProtogemasTengoNumero;

    private int ProtogemasNumero;

    private void Start()
    {
        ProtogemasNumero = transform.childCount;
    }

    private void Update()
    {
        ProtogemasTotales.text = ProtogemasNumero.ToString();
        ProtogemasTengoNumero = ProtogemasNumero - transform.childCount;
        ProtogemasTengo.text = ProtogemasTengoNumero.ToString();
    }

    public void TodoPillao()
    {
        if (transform.childCount == 1)
        {
            Debug.Log("NO quedan protogemas");
        }
    }
}
