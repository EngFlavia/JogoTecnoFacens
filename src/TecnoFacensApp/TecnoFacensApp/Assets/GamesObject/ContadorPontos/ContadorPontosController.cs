using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContadorPontosController : MonoBehaviour
{
    public GameObject placarObj;
    public GameObject palavraSorteadaObj;
    public GameObject letrasPegasObj;
    public GameObject telaGameOver;
    public GameObject placarFinalObj;
    public Button botaoStart;
    

    private Text placar;
    private Text palavraSorteada;
    private Text letrasPegas;
    private Text placarFinal;

    private int pontos = 0;
    private List<string> dicionarioDePalavras { get; set; } = new List<string>();
    private string palavra;
    private List<char> listaDeLetras;
    

    // Start is called before the first frame update    
    void Start()
    {
        CriarDicionario();
        placar = placarObj.GetComponent<Text>();
        palavraSorteada = palavraSorteadaObj.GetComponent<Text>();
        letrasPegas = letrasPegasObj.GetComponent<Text>();
        placarFinal = placarFinalObj.GetComponent<Text>();

        SortearPalavra();
        botaoStart.onClick.AddListener(Restart); ;
        
        telaGameOver.active = false;       

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SortearPalavra()
    {
        int indexSorteio = Random.Range(0, dicionarioDePalavras.Count());
        palavra = dicionarioDePalavras[indexSorteio]; 
        palavraSorteada.text = palavra;
        listaDeLetras = TransformaPalavraArray(palavra);
    }

    private void LimparPalavra()
    {
        letrasPegas.text = "";
    }

    private void AtualizaPlacar()
    {
        placar.text = pontos.ToString();
    }

    private void AddPontos()
    {
        pontos++;
        AtualizaPlacar();
    }

    public void AddPontosLetras(string letra)
    {
        Debug.Log("A letra que chegou no controlador é " + letra);

        if (VerificaLetra(letra))
        {
            AddPontos();       
        }
        else
        {
            GameOver();
        }

    }

    private bool VerificaLetra(string letra)
    {
        if (listaDeLetras[0].ToString() == letra)
        {
            letrasPegas.text += letra;
            listaDeLetras.Remove(listaDeLetras[0]);
            if (listaDeLetras.Count() <= 0)
            {
                SortearPalavra();
                LimparPalavra();
            }

            return true;
        }

        return false;
    }

    private void GameOver()
    {
        placarFinal.text = pontos.ToString();
        telaGameOver.active = true;
        Time.timeScale = 0;
    }

    private List<char> TransformaPalavraArray(string palavraSorteada)
    {        
        char[] charArr = palavraSorteada.ToCharArray();
        return charArr.ToList();
    }

    private void CriarDicionario()
    {
        dicionarioDePalavras.Add("ABACAXI");
        dicionarioDePalavras.Add("ARARA");
        dicionarioDePalavras.Add("CASA");
        dicionarioDePalavras.Add("COLHER");
        dicionarioDePalavras.Add("COPO");
        dicionarioDePalavras.Add("PAREDE");
        dicionarioDePalavras.Add("PAREDE");
    }
     
    private void Restart()
    {
        telaGameOver.active = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
