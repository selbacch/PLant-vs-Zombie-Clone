using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle : MonoBehaviour
{
    public GameObject katana;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void apkatana()
    {
        katana.SetActive(true);
    }
   public void somekatana()
    {
        katana.SetActive(false);
    }

}
