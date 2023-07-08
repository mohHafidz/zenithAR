using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        if (!PlayerPrefs.HasKey("HasInstalledBefore"))
        {
            // Tampilkan scene yang ingin ditampilkan ketika pertama kali diinstal
            SceneManager.LoadScene("policy");
            
            // Set PlayerPrefs agar tidak menampilkan scene lagi pada runtime berikutnya
            PlayerPrefs.SetInt("HasInstalledBefore", 1);
            PlayerPrefs.Save();
        }
    }

		public int idPanel;
        public string scene1 = "menuUtama1";
        public string scene2 = "scan1";

		// public static GameManager instance;
        // void Awake()
        // {
        //     if (instance == null)
        //     {
        //         instance = this;
        //         DontDestroyOnLoad(gameObject);
        //     }
        //     else
        //     {
        //         Destroy(gameObject);
        //     }
        // }
		// public void Set(int tempId)
		// {
		// 		idPanel = tempId;
		// }
   
}