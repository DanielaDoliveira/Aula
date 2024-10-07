using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    
    /*
     *Computador, preciso que você pegue um espaço na memória que guarde SOMENTE números
     * esses números precisam ser INTEIROS (0,1,2,3,4,5,6,7,8,9,10,...)
     * esse espaço novo que você vai guardar para mim se chama vida
     * */
     int vida;


    void Start()
    {
        //Ao iniciar o jogo, mude o valor da variável vida para 3
        vida = 3;
        
        //Computador, preciso que você chame aqui um evento que criei chamado TirarVida
        TirarVida();
    }

    // Update is called once per frame
    void Update()
    {

    }
    /*
     *Computador, preciso que meu personagem tenha um evento chamado TirarVida
     * esse evento precisa pegar a variável chamada vida que você guardou na memória
     * e diminuir um ponto da vida dele.
     * para isso precisamos fazer o computador fazer uma conta de subração
     * exemplo : vida = vida - 1 -> se a vida for 3, por exemplo: vida = 3-1 
     */
    void TirarVida()
    {
        vida = vida - 1;
        //Mostre no console da Unity o valor da variável vida após chamar o método de TirarVida
        Debug.Log(vida);
        
    }


    void TirarVidaComCondicoes()
    {
        if (vida > 0)
        {
            vida = vida - 1;
        
            Debug.Log(vida); 
        }
        else
        {
            Debug.Log("valor de vida não pode mais ser diminuido");
        }
    }

   

    
 
  
  
}
