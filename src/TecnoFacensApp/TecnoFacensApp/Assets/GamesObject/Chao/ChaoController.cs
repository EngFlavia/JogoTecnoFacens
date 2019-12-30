using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaoController : MonoBehaviour
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
            GameObject.Destroy(col.gameObject);
            //contadorPontos.GetComponent<ContadorPontosController>().GameOver();
            
        }

        //Debug.Log(col.gameObject.tag + " : " + gameObject.name);


    }
}
