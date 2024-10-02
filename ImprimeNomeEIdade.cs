using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImprimeNomeEIdade : MonoBehaviour
{
   public int idade;
   public string nome;
    void Start()
    {
        nome = "Daniela D";
        idade = 10;
      ImprimirNomeEIdade();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ImprimirNomeEIdade()
    {
        Debug.Log(nome + idade);
        /*
         *  soma (+)-> quando está entre dois números 1 + 1 = 2
         *  concatenação (+) -> quando está entre caracteres e um número => A + 1 => A1
         * -> quando está entre duas variáveis que sejam caracteres -> A + B => AB
         */ 
    }
}
