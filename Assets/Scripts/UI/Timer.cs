using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public float timer = 240;
    public Text texto;
    float oldTimer;
    bool isRunning = true;
    public MenuFaseController controle;
    void Start()
    {
        oldTimer = timer;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            timer -= Time.deltaTime;
          texto.text = "Tempo: " + Mathf.RoundToInt(timer).ToString() + " s";

        
        }
        if (timer < 0)
        {
            isRunning = false;
            controle.Win();
        }
    }
}
