using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImprimeNomeESobrenome : MonoBehaviour
{
    /*
     *Computador, preciso que você pegue um espaço na memória que guarde letras
     * essas letras são caracteres (a,b,c,d,e,f,...)
     * esse espaço novo que você vai guardar para mim se chama meuNome
     * */
    string meuNome;
    /*
     *Computador, preciso que você pegue um espaço na memória que guarde letras
     * essas letras são caracteres (a,b,c,d,e,f,...)
     * esse espaço novo que você vai guardar para mim se chama meuSobrenome
     * */
    string meuSobrenome;
    void Start()
    {
        //computador, quero que você altere a variável meu nome para Daniela.
        meuNome = "Daniela";
        //computador, quero que você altere a variável meu sobrenome para Doliveira.
        meuSobrenome = "Doliveira";
            //Computador, preciso que você chame aqui um método que criei
        //chamado ExibirMeuNomeESobrenome
        ExibirMeuNomeESobrenome();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ExibirMeuNomeESobrenome()
    {
        Debug.Log( meuNome + " "+ meuSobrenome);
    }


}
