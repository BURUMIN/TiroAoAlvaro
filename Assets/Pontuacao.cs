using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    float pontos = 0;
    public TextMeshProUGUI teste;

    public void addPoint(){
        pontos++;
        teste.text=pontos.ToString();
    }
    // Start is called before the first frame update
    void Start()
    {
        teste.text = "0";
    }
}
