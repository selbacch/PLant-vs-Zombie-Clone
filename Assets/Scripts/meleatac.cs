using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleatac : MonoBehaviour
{
        public float Damage;
    public bool bullet;
    public AudioSource myaudio;

    private void Start()
    {
       
    }
    // Start is called before the first frame update

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
        {myaudio.Play();
            Animator anim = collision.gameObject.GetComponentInChildren<Animator>();
            anim.SetTrigger("hit");
            
            collision.gameObject.GetComponent<Healt>().Life -= Damage;
            if(bullet == true)
            {
                Destroy(gameObject);
            }

        }
    }
   
}
