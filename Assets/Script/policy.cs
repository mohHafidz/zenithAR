using UnityEngine;
using UnityEngine.SceneManagement;

public class policy : MonoBehaviour
{
    void Awake()
    {
        // Mengecek apakah aplikasi dijalankan untuk pertama kali
        if (PlayerPrefs.GetInt("isFirstTime", 0) == 0)
        {
            // Jika ya, buka scene khusus ini dan set flag isFirstTime menjadi 1
            PlayerPrefs.SetInt("isFirstTime", 1);
        }
            SceneManager.LoadScene("menuUtama1");
    }
}
