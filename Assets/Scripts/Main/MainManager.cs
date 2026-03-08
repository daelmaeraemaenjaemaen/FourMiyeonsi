using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class MainManager : MonoBehaviour
{
    bool loading = false;

    void Update()
    {
        if (loading) return;

        if (Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            loading = true;
            SceneManager.LoadScene("Title");
        }
    }

    public void StartButton()
    {
        if (loading) return;
        loading = true;
        SceneManager.LoadScene("Start");
    }

    public void CharactersButton()
    {
        if (loading) return;
        loading = true;
        SceneManager.LoadScene("Characters");
    }

    public void EndingsButton()
    {
        if (loading) return;
        loading = true;
        SceneManager.LoadScene("Endings");
    }

    public void CreditsButton()
    {
        if (loading) return;
        loading = true;
        SceneManager.LoadScene("Credits");
    }
}