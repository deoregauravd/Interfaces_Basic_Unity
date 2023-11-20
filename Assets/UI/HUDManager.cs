using UnityEngine;

public class HUDManager : MonoBehaviour
{
    private static HUDManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // If there is already an instance of the HUD, destroy this duplicate.
            Destroy(gameObject);
        }
    }

    // Other HUD-related methods and functionality
}
