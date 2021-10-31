using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float MoveSpeed;
    public bool canmove;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
        if (canmove) { 
            transform.Translate(Vector3.left * MoveSpeed * Time.deltaTime);
        }
    }
    IEnumerator HIt()
    {
        yield return new WaitForSeconds(0.8f);
        canmove = false;
    }




}
