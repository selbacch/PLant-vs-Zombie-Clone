using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidShoot : MonoBehaviour
{
   
    public float Cooldown;
    private float cd;
    public GameObject projetil;
    // Start is called before the first frame update
    void Start()
    {
        cd = Cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (cd > 0)
        {
            cd -= Time.deltaTime;

        }
        else
        {
            if (Physics.Raycast(transform.position, Vector3.right, 30))
            {
                int repet = 1;
                StartCoroutine(FastShoot(repet));
            }
        }
    }


    public IEnumerator FastShoot(int Tempo)
    {
        for (int i = 0; i < Tempo; i++)
        {

            Instantiate(projetil, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
        

    }



}
