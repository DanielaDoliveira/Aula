using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImprimeMeuNome : MonoBehaviour
{
/*Computador, preciso que você pegue um espaço na memória que guarde letras
    * essas letras são caracteres (a,b,c,d,e,f,...)
* esse espaço novo que você vai guardar para mim se chama meuNome
    * */
    private string meuNome;
    void Start()
    {
        //computador, quero que você altere a variável meuNome para Daniela.
        meuNome = "Daniela";
        //Computador, preciso que você chame aqui um método que criei
        //chamado ImprimirMeuNome
       ImprimirMeuNome();
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void ImprimirMeuNome()
    {
        //Computador, exiba para mim o valor que tem na variável meuNome
        Debug.Log(meuNome);
    }
    
}
