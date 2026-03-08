using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class EndingsManager : MonoBehaviour
{
    bool loading = false;

    void Update()
    {
        if (loading) return;

        if (Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            loading = true;
            SceneManager.LoadScene("Main");
        }
    }
}