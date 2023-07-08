using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject aboutus, home, scan, screenshot, btn_scan;
    void start()
    {
        screenshot.SetActive(false);
    }
    //pidah scene ke about
    public void pindahScene(string name){
        if(name == "about us"){
            screenshot.SetActive(false);
            home.SetActive(false);
            aboutus.SetActive(true);
            btn_scan.SetActive(true);
            scan.SetActive(false);
        }
        else if (name == "home page")
        {
            aboutus.SetActive(false);
            screenshot.SetActive(false);
            home.SetActive(true);
            btn_scan.SetActive(true);
            scan.SetActive(false);
        }
        else if(name == "scan")
        {
            aboutus.SetActive(false);
            home.SetActive(false);
            scan.SetActive(true);
            btn_scan.SetActive(false);
            screenshot.SetActive(true);
        }
    }
}
