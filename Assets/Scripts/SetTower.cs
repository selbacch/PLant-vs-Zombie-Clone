using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SetTower : MonoBehaviour
{
    public int selected;
    public GameObject[] towers;
    public float[] prices;
    public GameObject tile;
    private Money mscr;
    // Start is called before the first frame update
    void Start()
    {
        mscr = GameObject.Find("logica").GetComponent<Money>();
    }

    // Update is called once per frame
    void Update()
    {
   

    }

    public void OnMove(InputValue Value)
    {
       
        Ray ray = Camera.main.ScreenPointToRay(Value.Get<Vector2>());
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 20))
        {
            if (hit.transform.tag == "lajota")
            {

                tile = hit.transform.gameObject;


            }
            else { tile = null; }
            
        }

    }

    public void OnClick(InputValue value)
    {
        if (tile != null)
        {
            LajotaTaken tscr = tile.GetComponent<LajotaTaken>();
            if (!tscr.isTaken && mscr.money > prices[selected])
            {
                mscr.money -= prices[selected];
                Vector3 pos = new Vector3(tile.transform.position.x, .8F, tile.transform.position.z);
                tscr.Tower = (GameObject)Instantiate(towers[selected], pos, Quaternion.identity);
                tscr.isTaken = true; }
        
        }
    }
    

  



}