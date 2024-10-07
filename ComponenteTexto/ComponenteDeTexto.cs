using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ComponenteDeTexto : MonoBehaviour
{
    public TextMeshProUGUI componenteTexto;
    public string mensagem;
    void Start()
    {
        ImprimirTexto();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ImprimirTexto()
    {
        componenteTexto.text = mensagem;
    }
}
