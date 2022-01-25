using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador_Esferas : MonoBehaviour
{
    public GameObject prefab_esfera;
    public int cantidad;
    public int rangoX;
    public int rangoZ;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(prefabSpawn());
    }

    // Update is called once per frame
    void Update()
    {

    } 

    IEnumerator prefabSpawn()
    {
        for (int i = 0; i < cantidad; i++)
        {
            float posX = Random.Range(-rangoX / 2, rangoX / 2);
            float posZ = Random.Range(-rangoZ / 2, rangoZ / 2);
            Instantiate(prefab_esfera, new Vector3(posX, 1, posZ), Quaternion.identity);

            yield return new WaitForSeconds(1);
        }
    }
}
