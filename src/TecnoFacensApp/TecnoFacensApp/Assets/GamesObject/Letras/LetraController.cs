using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetraController : MonoBehaviour

{
    private bool direcaoup = true;
    private float velocidade = 2.0f;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * velocidade * Time.deltaTime;
    }


}