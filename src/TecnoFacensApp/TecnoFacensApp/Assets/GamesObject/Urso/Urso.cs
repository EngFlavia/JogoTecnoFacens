using UnityEngine;
public class Urso : MonoBehaviour
{
    public GameObject ParedeEsquerda;
    public GameObject ParedeDireita;

    private float velocidade = 5.0f;
    private bool direcaoEsquerda = true;
    private float limiteEsquerdo;
    private float limiteDireito;


    // Start is called before the first frame update
    void Start()
    {
        limiteEsquerdo = ParedeEsquerda.transform.position.x;
        limiteDireito = ParedeDireita.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        var vel = velocidade;

        if (Input.GetButton("Fire1"))
        {
            vel = vel * 2;
        }

        if ((Input.GetKey(KeyCode.LeftArrow) || (Input.GetAxis("Horizontal") < -0.5)) && 
            limiteEsquerdo < this.gameObject.transform.position.x)
        {

            transform.position += Vector3.left * vel * Time.deltaTime;
        }
        else if ((Input.GetKey(KeyCode.RightArrow) || (Input.GetAxis("Horizontal") > 0.5)) && 
            limiteDireito > this.gameObject.transform.position.x)
        {
            transform.position += Vector3.right * vel * Time.deltaTime;
        }
       
    }

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.CompareTag("Parede"))
    //        direcaoEsquerda = !direcaoEsquerda;

    //    //Debug.Log(col.gameObject.tag + " : " + gameObject.name);


    //}
}
