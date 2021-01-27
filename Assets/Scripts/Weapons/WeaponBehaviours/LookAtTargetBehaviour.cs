using UnityEngine;

public class LookAtTargetBehaviour : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private Transform target;

    private void Update()
    {
        if (target == null) return;

        Vector3 toTarget = target.position - transform.position;
        float angle = Mathf.Atan2(toTarget.y, toTarget.x) * Mathf.Rad2Deg - 90f;
        Quaternion quaternion = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, quaternion, speed * Time.deltaTime);
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }
}