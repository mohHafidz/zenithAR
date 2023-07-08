using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenShot : MonoBehaviour
{

    private int index_filter;
    public GameObject WaterMark;
    public GameObject navBar;
    public GameObject groupButton;
    public Image pictureHolder;
    public GameObject [] filter;
    public GameObject btn_filter;

    // Start is called before the first frame update
    void Start()
    {
        WaterMark.SetActive(false);
        ShowPictureHolder(false);
        index_filter = 0;
        filter[0].SetActive(true);
        for (int i = 1; i < 4; i++)
        {
            filter[i].SetActive(false);
            
        }
    }

    private void ShowPictureHolder(bool visible)
    {
        pictureHolder.gameObject.SetActive(visible);
    }

    public void next_filter()
    {
        int from = index_filter;
        index_filter = (index_filter + 1) % 4;
        filter[from].SetActive(false);
        filter[index_filter].SetActive(true);
    }

    public void prev_filter()
    {
        int from = index_filter;
        index_filter = (index_filter - 1);
        if(index_filter == -1)
            index_filter = 3;
        filter[from].SetActive(false);
        filter[index_filter].SetActive(true);
    }

    public void TakeScreenshot()
    {
        navBar.SetActive(false);
        btn_filter.SetActive(false);
        groupButton.SetActive(false);
        WaterMark.SetActive(true);
        filter[index_filter].SetActive(true);
        GleyShare.Manager.CaptureScreenshot(screenshotCaptured);
    }

    private void screenshotCaptured(Sprite sprite)
    {
        if(sprite != null){
            pictureHolder.sprite = sprite;
            ShowPictureHolder(true);
            WaterMark.SetActive(false);
            filter[index_filter].SetActive(false);
        }
    }

    public void cancel()
    {
        groupButton.SetActive(true);
        navBar.SetActive(true);
        btn_filter.SetActive(true);
        ShowPictureHolder(false);
        filter[index_filter].SetActive(true);
    }

    public void share()
    {
        GleyShare.Manager.SharePicture();
    }
}
