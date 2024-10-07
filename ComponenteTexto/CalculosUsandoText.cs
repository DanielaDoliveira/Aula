using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CalculosUsandoText : MonoBehaviour
{
     int n1;
     int n2;
      int opcao;
      int resultado;
      public TextMeshProUGUI resultadoIntParaString;
    void Start()
    {
        
    }

  
    void Update()
    {
        Calcular();
    }

    public void Botao01()
    {
        opcao = 1;
    }

    public void Botao02()
    {
        opcao = 2;
    }

    void Calcular()
    {
        if (opcao == 1)
        {
            resultado = n1 + n2;
            resultadoIntParaString.text = resultado.ToString();

        }
        else if (opcao == 2)
        {
            resultado = n1 - n2;
            resultadoIntParaString.text = resultado.ToString();
        }
    }
    
}
