using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;
public class shoot : MonoBehaviour
{
    public float Cooldown;
    private float cd;
    public GameObject projetil;
    public bool hasenemy;
    public bool mele;
    public GameObject ligth;


    public float ANIMtIM;

    // Start is called before the first frame update
    void Start()
    {
        cd = Cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (mele == false)
        {
            if (cd > 0)
            {
                cd -= Time.deltaTime;

            }
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.right, out hit, 15))
            {
                if (hit.transform.tag == "enemy")
                {
                    
                    if (cd <= 0)
                    {
                        ligth.SetActive(false);
                        cd = Cooldown;
                        Animator anim = GetComponentInChildren<Animator>();
                        anim.SetTrigger("atack");
                        StartCoroutine(Bala());
                    }

                    hasenemy = true;
                }
                else if (hit.transform.tag == "tower")
                {
                    shoot scr = hit.transform.gameObject.GetComponent<shoot>();
                    if (scr.hasenemy) { hasenemy = true; } else { hasenemy = false; }
                }
                else { hasenemy = false; }
            }
            else { hasenemy = false; }
            if (hasenemy)
            {
                if (cd <= 0)
                {
                    cd = Cooldown;
                    Animator anim = GetComponentInChildren<Animator>();
                    anim.SetTrigger("atack");
                    StartCoroutine(Bala());
                }

            }

        }



        if (mele == true)
        {
            if (cd > 0)
            {
                cd -= Time.deltaTime;

            }
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.right, out hit, 3f))
            {
                
                if (hit.transform.tag == "enemy")
                {
                    if (cd <= 0)
                    {
                        cd = Cooldown;
                        Animator anim = GetComponentInChildren<Animator>();
                        anim.SetTrigger("atack");
                        
                    }

                    hasenemy = true;
                }
                else if (hit.transform.tag == "tower")
                {
                    shoot scr = hit.transform.gameObject.GetComponent<shoot>();
                    if (scr.hasenemy) { hasenemy = true; } else { hasenemy = false; }
                }
                else { hasenemy = false; }
            }
            else { hasenemy = false; }
            if (hasenemy)
            {
                if (cd <= 0)
                {
                    cd = Cooldown;
                    Animator anim = GetComponentInChildren<Animator>();
                    anim.SetTrigger("atack");
                    
                }

            }

        }






    }

    IEnumerator Bala()
    {
        yield return new WaitForSeconds(ANIMtIM);
        Instantiate(projetil, transform.position, Quaternion.identity);
        ligth.SetActive(true);
    }




}
