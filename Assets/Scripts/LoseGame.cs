using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseGame : MonoBehaviour
{
    public bool lose;
    private Money mscr;
    private float initmoney;
    private WaveManger wavscr;
    // Start is called before the first frame update
    void Start()
    {
        mscr = gameObject.GetComponent<Money>();
        wavscr = gameObject.GetComponent<WaveManger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lose)
        {
            lose = false;
            wavscr.reseted();
            GameObject[] towers = GameObject.FindGameObjectsWithTag("Tower");
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("enemy");
            for(int i =0; i<towers.Length;i++)
            {
                Destroy(towers[i]);
            }
            for(int j =0; j < enemies.Length; j++)
            {
                Destroy(enemies[j]);
            }
            GameObject[] tiles = GameObject.FindGameObjectsWithTag("lajota");
            for(int n =0; n < tiles.Length; n++){
                LajotaTaken tscrs = tiles[n].GetComponent<LajotaTaken>();
                tscrs.isTaken = false;
            }
            GameObject[] projetil = GameObject.FindGameObjectsWithTag("Projetil");
            for (int x = 0; x < projetil.Length; x++)
            {
                Destroy(projetil[x]);

            }
                mscr.money = initmoney;
        }
    }
}
