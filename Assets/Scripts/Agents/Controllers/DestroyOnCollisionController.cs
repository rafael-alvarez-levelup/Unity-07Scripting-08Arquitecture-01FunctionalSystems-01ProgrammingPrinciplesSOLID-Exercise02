using UnityEngine;

public class DestroyOnCollisionController : MonoBehaviour
{
    [SerializeField] private LayerMask destroyMask;

    private DestroyBehaviour destroyBehaviour;

    private void Awake()
    {
        destroyBehaviour = GetComponent<DestroyBehaviour>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Destroy game object if other game object is in the assigned destroy layer.
        if (ContainsLayer(other.gameObject.layer))
        {
            destroyBehaviour.Destroy();
        }
    }

    private bool ContainsLayer(int layer) => destroyMask == (destroyMask | (1 << layer));
}