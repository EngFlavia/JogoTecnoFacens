using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColmeiaController : MonoBehaviour
{
    public GameObject[] Letras;
   
    private float tempoInicial;
    private float tempoIntervalo;
    private int numeroDeLetras;
    
    // Start is called before the first frame update
    void Start()
    {
        numeroDeLetras = Letras.Length;
        Debug.Log("Tamanho do array é: " + numeroDeLetras.ToString());
        tempoInicial = Time.time;
        tempoIntervalo = Random.RandomRange(1f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > tempoInicial+tempoIntervalo)
        {
            Instantiate(Letras[Random.Range(0,numeroDeLetras)], this.transform.position, new Quaternion());
            tempoInicial = Time.time;
            tempoIntervalo = Random.RandomRange(1f, 5f);
            //Instantiate(Mel, position : this.gameObject.transform.position, new Quaternion());
        }
    }
}
