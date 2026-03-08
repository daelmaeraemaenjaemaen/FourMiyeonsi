using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using System.Collections;

public class TitleManager : MonoBehaviour
{
    bool loading = false;

    void Update()
    {
        if (loading) return;

        if (Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Application.Quit();
            return;
        }

        if (Keyboard.current != null && Keyboard.current.anyKey.wasPressedThisFrame)
        {
            loading = true;
            StartCoroutine(LoadMain());
            return;
        }

        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            loading = true;
            StartCoroutine(LoadMainAfterMouseRelease());
        }
    }

    IEnumerator LoadMain()
    {
        yield return null;
        SceneManager.LoadScene("Main");
    }

    IEnumerator LoadMainAfterMouseRelease()
    {
        while (Mouse.current != null && Mouse.current.leftButton.isPressed)
        {
            yield return null;
        }

        SceneManager.LoadScene("Main");
    }
}