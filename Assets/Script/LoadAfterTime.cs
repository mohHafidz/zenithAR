using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using  UnityEngine.SceneManagement;

public class LoadAfterTime : MonoBehaviour
{

    [SerializeField]
    public float delayBeforeLoading;

    [SerializeField]
    public string sceneNameToLoad;
    private float timeElapsed;

    // Update is called once per frame
    // void Update()
    // {
    //     timeElapsed += Time.deltaTime;

    //     if(timeElapsed > delayBeforeLoading){
    //         SceneManager.LoadScene(sceneNameToLoad);
    //     }
    // }
    // private SceneFader fader;

    void Start()
    {
        Debug.Log("Test");
        ChangeSceneWithFadeOut(delayBeforeLoading,sceneNameToLoad);
    }

    public Image fadeImage; // Referensi ke komponen Image
    public float fadeSpeed; // Kecepatan efek fade-out
    public void ChangeSceneWithFadeOut(float delay, string sceneName)
    {
        StartCoroutine(ChangeSceneWithDelayAndFadeOut(delay, sceneName)); // Mulai dengan menunggu sejumlah waktu dan efek fade-out
    }

    IEnumerator ChangeSceneWithDelayAndFadeOut(float delay, string sceneName)
    {
        
        Color originalColor = fadeImage.color; // Salin warna asli dari gambar
        fadeImage.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0f);
        yield return new WaitForSeconds(delay); // Tunggu sejumlah waktu yang ditentukan
        float alpha = 0f; // Mulai dengan opacity minimum (0)

        while (alpha < 1f) // Selama opacity belum mencapai maksimum (1)
        {
            alpha += Time.deltaTime * fadeSpeed; // Tambahkan opacity sesuai kecepatan yang ditentukan
            Color newColor = new Color(originalColor.r, originalColor.g, originalColor.b, alpha); // Buat warna baru dengan opacity yang bertambah
            fadeImage.color = newColor; // Setel warna gambar ke warna baru
            yield return null; // Tunggu frame berikutnya
        }
        
        // Pindah ke scene baru setelah efek fade-out
        UnityEngine.SceneManagement.SceneManager.LoadScene("policy");
    }
}
