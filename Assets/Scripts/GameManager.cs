using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public AudioSource audio;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void GameOver()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            audio.Play();
            Debug.Log("Game Over");
            Invoke("Restart",  3f);
        }
        
    }

    public void Restart()
    {
      SceneManager.LoadScene(0);
    }
}
