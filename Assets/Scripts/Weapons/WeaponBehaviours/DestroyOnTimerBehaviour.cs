using UnityEngine;

public class DestroyOnTimerBehaviour : MonoBehaviour
{
    [SerializeField] private float timer;

    private void Start()
    {
        Destroy(gameObject, timer);
    }
}