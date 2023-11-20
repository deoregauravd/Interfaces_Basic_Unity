using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private IUIElement[] uiElements;

    void Start()
    {
        // Access the methods of UI elements through the interface
        foreach (var uiElement in uiElements)
        {
            uiElement.Show();
        }
    }

}
