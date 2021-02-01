using UnityEngine;

public class EngineBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject engine;

    // Activates or deactivates the visual effects of the engine.
    public void Toggle(bool isActive)
    {
        if (isActive && engine.activeInHierarchy)
        {
            return;
        }

        if (!isActive && !engine.activeInHierarchy)
        {
            return;
        }

        engine.SetActive(isActive);
    }
}