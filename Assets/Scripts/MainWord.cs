using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class MainWord : MonoBehaviour
{
    AudioSource audioData;
    int soundPlaying = 0;

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void GoToTask()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ManagerSound()
    {
        audioData = GetComponent<AudioSource>();    
        
        if (soundPlaying == 0) {
            soundPlaying = 1;
            audioData.Play();
            Debug.Log("Started Audio");
        } else {
            soundPlaying = 0;
            audioData.Pause();
            Debug.Log("Started Audio");
        }
        
    }

    public void ExitGame()
    {        
        Application.Quit();
    }
}
