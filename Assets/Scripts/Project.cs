using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Project : MonoBehaviour
{
    public float MoveSpeed;
    public float Damage;
    public Vector3 initpos;
    public AudioSource myaudio;
    //public GameObject DestroyEfect;
    // Start is called before the first frame update
    void Start()
    {
        
        myaudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * MoveSpeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, initpos) > 20) { Destroy(gameObject); }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            other.GetComponent<Healt>().Life -= Damage;
            //DestroyEfect.SetActive(true);
            Destroy(gameObject);
        }
    }


}
