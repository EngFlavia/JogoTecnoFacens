using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoteController : MonoBehaviour
{
    public GameObject contadorPontos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag != "Urso")
        {
            Debug.Log("Letra encontrada " + col.tag);

            contadorPontos.GetComponent<ContadorPontosController>().AddPontosLetras(col.tag);
            GameObject.Destroy(col.gameObject);
        }
        
    }
}
