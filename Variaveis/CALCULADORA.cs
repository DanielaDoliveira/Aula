using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CALCULADORA : MonoBehaviour
{
    public int n1;
    public int n2;
    private int resultado;
    public int opcao;
    void Start()
    {
        MenuDeOpcoes();
       
    }

    void MenuDeOpcoes()
    {
        if (opcao == 1)
        {
            Somar();
        }
        else if (opcao == 2)
        {
            Subtrair();
        }
        else if (opcao == 3)
        {
            Multiplicar();
        }
        else if (opcao == 4)
        {
            Dividir();
        }
        else
        {
            Debug.Log("Escolha uma opção entre 1 e 4");
        }
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    void Somar()
    {
        resultado = n1 + n2;
        Debug.Log(resultado);
    }

    void Subtrair()
    {
        resultado = n1 - n2;
        Debug.Log(resultado);
    }

    void Multiplicar()
    {
        resultado = n1 * n2;
        Debug.Log(resultado);
    }

    void Dividir()
    {
        
        if (n2 == 0)
        {
            Debug.Log("Não existe divisão com denominador zero!");
        }
        else
        {
            resultado = n1 / n2;
            Debug.Log(resultado);
        }
    }

   
}
