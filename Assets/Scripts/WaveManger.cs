using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManger : MonoBehaviour
{
    public int NumOut;
    public float inipause;
    public GameObject [] Enemys;
    public float Cooldown;
    private float cd;
    // Start is called before the first frame update
    void Start()
    {
        cd = Cooldown*inipause;
    }

    // Update is called once per frame
    void Update()
    {
       if(cd > 0)
        {
            cd -= Time.deltaTime;
        }
        else { cd = Cooldown;
            Vector3 pos = new Vector3(5, 1, Random.Range(-2, 3));
            int index = Random.Range(0, Enemys.Length);
            Instantiate(Enemys[index], pos, Quaternion.identity);
            NumOut++;
        }
    }

    public void reseted()
    {
        cd = Cooldown;
    }



}
