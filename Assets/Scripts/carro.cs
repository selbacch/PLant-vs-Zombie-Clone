﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carro : MonoBehaviour
{
    public MenuFaseController controle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
            
            if (other.gameObject.tag == "enemy")
            {

                controle.GetComponent<MenuFaseController>().AbrirMenuMorte();
            }

        
    }

}
