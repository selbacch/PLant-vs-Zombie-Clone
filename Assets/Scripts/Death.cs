using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public bool  ISTower;
    public bool deat;
        private Healt hscr;
    private Money mscr;
    private EnemyStats escr;
    // Start is called before the first frame update
    void Start()
    {
        hscr = gameObject.GetComponent<Healt>();
        mscr = GameObject.Find("logica").GetComponent<Money>();
        if (!ISTower)
        {
            escr = gameObject.GetComponent<EnemyStats>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(hscr.Life <= 0)
        {
            if (ISTower)
            {
                Animator anim = GetComponentInChildren<Animator>();
                anim.SetBool("Death",true);
                dead(4);
                deat = true;
            }
            else {
                mscr.money += escr.Worth ;
                Animator anim = GetComponentInChildren<Animator>();
                anim.SetBool("Death", true);
                dead(3); }
            deat = true;
        }
    }

   void dead(float time)
    {
       
        Destroy(gameObject, time);
    }


}
