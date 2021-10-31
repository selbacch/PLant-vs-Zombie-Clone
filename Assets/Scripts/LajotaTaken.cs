using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LajotaTaken : MonoBehaviour
{
    public bool isTaken;
    public GameObject Tower;
    // Start is called before the first frame update
    void Start()
    {
        if (Tower == null)
            return;
    }

    // Update is called once per frame
    void Update()
    {
        if (Tower!=null)
        {
            if (Tower.GetComponent<Death>().deat == true)
            {
                isTaken = false;

            }
        }
        if (Tower == null)
            return;
    }
}
