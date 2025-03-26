using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class running : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        switch (other.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("this is friendly");
                break;
            case "Finish":
                LoadNextLevel();
                break;
            case "Fuel":
                Debug.Log("out of fuel");
                break;
            default:
                ReloadLevel();
                break;
        }
    }
    void LoadNextLevel()
    {
        int theLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(theLevel+1);
    }
    void ReloadLevel()
    {
        int theLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(theLevel);
    }
}
