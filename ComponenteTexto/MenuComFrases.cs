using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MenuComFrases : MonoBehaviour
{
    public TextMeshProUGUI texto;
    public Button botao01;
    public Button botao02;
     int opcao;
    string mensagem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        EscolherOpcao();
    }

    void EscolherOpcao()
    {
        if (opcao == 1)
        {
            texto.text = "Olá mundo";
        }
        else if (opcao == 2)
        {
            texto.text = "Hello world";
        }
        else
        {
            texto.text = "Opção Inválida";
        }
    }

    public void Opcao1()
    {
        opcao = 1;
    }

    public void Opcao2()
    {
        opcao = 2;
    }
}
