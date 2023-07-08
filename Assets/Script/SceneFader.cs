using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneFader : MonoBehaviour 
{
    public Image fadeImage; // Referensi ke komponen Image
    public float fadeSpeed = 1f; // Kecepatan efek fade-out

    public void Start()
    {
        Debug.Log("Masuk");
    }

    public void ChangeSceneWithFadeOut(float delay, string sceneName)
    {
        StartCoroutine(ChangeSceneWithDelayAndFadeOut(delay, sceneName)); // Mulai dengan menunggu sejumlah waktu dan efek fade-out
    }

    IEnumerator ChangeSceneWithDelayAndFadeOut(float delay, string sceneName)
    {
        yield return new WaitForSeconds(delay); // Tunggu sejumlah waktu yang ditentukan
        Color originalColor = fadeImage.color; // Salin warna asli dari gambar
        float alpha = 0f; // Mulai dengan opacity minimum (0)

        while (alpha < 1f) // Selama opacity belum mencapai maksimum (1)
        {
            alpha += Time.deltaTime * fadeSpeed; // Tambahkan opacity sesuai kecepatan yang ditentukan
            Color newColor = new Color(originalColor.r, originalColor.g, originalColor.b, alpha); // Buat warna baru dengan opacity yang bertambah
            fadeImage.color = newColor; // Setel warna gambar ke warna baru
            yield return null; // Tunggu frame berikutnya
        }

        // Pindah ke scene baru setelah efek fade-out
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
