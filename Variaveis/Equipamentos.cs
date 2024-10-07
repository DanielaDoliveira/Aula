using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipamentos : MonoBehaviour
{
   int ataqueBase;
   private int ataqueAtual;
    void Start()
    {
        ataqueBase = 100; // define um valor para o ataque base do status do jogador
        ataqueAtual = ataqueBase; // o ataque atual vai receber o valor que tem dentro da variável ataqueBase,
                                  // ou seja, ataqueAtual vai valer 100.
                                  
        //Chamando o método de Equipar Item:
        EquiparItem();
        //Chamando o método de Desequipar Item:
        DesequiparItem();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EquiparItem()
    {
        ataqueAtual = ataqueBase + 10; // aumenta 10 pontos 
        Debug.Log("Ataque com item equipado: "+ataqueAtual);
    }

    void DesequiparItem()
    {
        ataqueAtual = ataqueBase; //volta a valer os 100 pontos iniciais
        Debug.Log( ("Ataque sem item equipado: "+ ataqueAtual));
    }
}
