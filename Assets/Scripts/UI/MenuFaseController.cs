using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MenuFaseController : MonoBehaviour
{

    public GameObject menuInicio;
    public GameObject menuPause;
    public GameObject menuMorte;
    public GameObject menuWin;
    public GameObject panelEscureBackground;
    public GameObject Input;





    private float timeScale;
    public bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        timeScale = Time.timeScale;
        //FecharMenus();
        AbrirMenuInicio();
       
    }

    public void AbrirMenuPause()
    {
 
        menuMorte.SetActive(false);
        menuPause.SetActive(true);
       panelEscureBackground.SetActive(true);
        Time.timeScale = 0;
        isOpen = true;
       Input.GetComponent<PlayerInput>().actions.Disable();

    }

    public void AbrirMenuMorte()
    {
              
        menuMorte.SetActive(true);
        menuPause.SetActive(false);
        panelEscureBackground.SetActive(true);
        isOpen = true;Time.timeScale = 0;
        Input.GetComponent<PlayerInput>().actions.Disable();
    }

    public void FecharMenus()
    {
        menuMorte.SetActive(false);
        menuPause.SetActive(false);
        menuInicio.SetActive(false);
        panelEscureBackground.SetActive(false);
        Time.timeScale = this.timeScale;
        isOpen = false;
        Input.GetComponent<PlayerInput>().actions.Enable();

    }



    public void AbrirMenuInicio()
    {
        menuInicio.SetActive(true);
        menuMorte.SetActive(false);
        menuPause.SetActive(false);
        panelEscureBackground.SetActive(true);
        Time.timeScale = 0;
        isOpen = true;
        Input.GetComponent<PlayerInput>().actions.Disable();
    }
    public void Win()
    {
        menuWin.SetActive(true);
        menuInicio.SetActive(false);
        menuMorte.SetActive(false);
        menuPause.SetActive(false);
        panelEscureBackground.SetActive(true);
        Time.timeScale = 0;
        isOpen = true;
        Input.GetComponent<PlayerInput>().actions.Disable();
    }
    public  void Renew()
    {
        GameObject.Find("logica").GetComponent<LoseGame>().lose = true;
        FecharMenus();
    }
}
  



