using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    private EnemyMove movscr;
    public float damage;
    public float Cooldown;
    private float cd;
    
    // Start is called before the first frame update
    void Start()
    {
        movscr = gameObject.GetComponent<EnemyMove>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cd > 0)
        {
            cd -= Time.deltaTime;

        }
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.left, out hit, .6f))
        {
            if (hit.transform.tag == "Tower")
            {
                if (cd <= 0)
                { Animator Anim = hit.transform.gameObject.GetComponentInChildren<Animator>();
                    Anim.SetTrigger("hit");
                    Animator anim = GetComponentInChildren<Animator>();
                    anim.SetTrigger("atack");
                    Healt hscr = hit.transform.gameObject.GetComponent<Healt>();
                    hscr.Life -= damage;
                    cd = Cooldown;
                }
            }
           
            movscr.canmove = false;
        } else if (movscr.canmove == false)
        {
            movscr.canmove = true;
        }
    }
}
