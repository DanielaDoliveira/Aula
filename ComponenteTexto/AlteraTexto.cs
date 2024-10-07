using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class AlteraTexto : MonoBehaviour
{
     public TextMeshProUGUI texto;
     public Button botao01;
     public Button botao02;
     public int opcao;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        AlterarTexto();
    }

    void AlterarTexto()
    {
        if (opcao == 1)
        {
            texto.text = " Olá mundo";
        }
        else if (opcao == 2)
        {
            texto.text = " Hello world";
        }
    }
    

  public  void AlterarTextoBotao01()
    {
        opcao = 1;



    }

   public void AlterarTextoBotao02()
    {
        opcao = 2;

    }
    
    

   
}
