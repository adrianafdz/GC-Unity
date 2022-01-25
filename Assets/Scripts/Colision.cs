using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision colision)
    {
        if (colision.transform.tag == "enemigo")
        {
            Destroy(colision.transform.gameObject);
        }
    }
}
