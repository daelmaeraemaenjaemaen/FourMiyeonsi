using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class MainManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Title");
        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene("Main");
    }

    public void CharactersButton()
    {
        SceneManager.LoadScene("Characters");
    }

    public void EndingsButton()
    {
           SceneManager.LoadScene("Endings");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("Credits");
    }
}
