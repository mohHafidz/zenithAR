using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linkToko : MonoBehaviour
{
    // Start is called before the first frame update
    public string url = "https://shp.ee/naidxt4";

    public void OpenUrl()
    {
        Application.OpenURL(url);
    }
}

