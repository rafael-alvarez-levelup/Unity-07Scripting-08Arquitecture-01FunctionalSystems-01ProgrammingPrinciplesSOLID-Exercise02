using UnityEngine;

public class SearchNearestTargetBehaviour : MonoBehaviour
{
    [SerializeField] private float radius;
    [SerializeField] LayerMask layer;

    public Transform SearchNearestTarget()
    {
        Transform target = null;

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius, layer);

        float distance = float.MaxValue;

        foreach(Collider collider in colliders)
        {
            if(Vector3.Distance(transform.position, collider.transform.position) < distance)
            {
                target = collider.transform;
            }
        }

        return target;
    }
}