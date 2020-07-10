using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class altura_personagem : MonoBehaviour{

    public Transform personagem;
    Text texto_altura;

    // Start is called before the first frame update
    void Start(){
        texto_altura = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update(){
        int altura = Mathf.RoundToInt(personagem.position.y);
        texto_altura.text = altura.ToString() + " metro";

        Debug.Log(altura);

        if (altura != 1){
            texto_altura.text = altura.ToString() + " metros";
        }
        
        if(altura <= -15){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (Input.GetKeyDown(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
