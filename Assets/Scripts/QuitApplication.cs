using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class QuitApplicaiton : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current.escapeKey.isPressed)
        {
            Debug.Log("Quit App");
            Application.Quit();
        }
    }
}