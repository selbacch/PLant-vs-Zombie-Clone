using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerButton : MonoBehaviour
{
    public int index;
    public SetTower setscr;
    // Start is called before the first frame update
   public void botao1()
    {
        setscr.selected = index;
    }
}
