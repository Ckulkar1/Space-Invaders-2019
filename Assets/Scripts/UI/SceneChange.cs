using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public AudioSource audioUI;

    

    void Start()
    {
        audioUI = GetComponent<AudioSource>();
    }

    public void Play()
    {
        audioUI.Play();
        SceneManager.LoadScene(0);
        
    }

    public void StartGame1()
    {
        audioUI.Play();
        SceneManager.LoadScene(1);
        
    }

    public void StartGame2()
    {
        audioUI.Play();
        SceneManager.LoadScene(2);
        
    }

    public void Quit()
    {
        Application.Quit();
    }
}
