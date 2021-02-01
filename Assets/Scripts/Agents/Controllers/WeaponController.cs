using UnityEngine;

// TODO: Allow weapon swap at runtime.

public class WeaponController : MonoBehaviour
{
    [SerializeField] private Transform firePoint;

    private WeaponBase weaponBase;

    private void Awake()
    {
        weaponBase = GetComponent<WeaponBase>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (weaponBase.CanFire())
            {
                weaponBase.Fire(firePoint);
                weaponBase.SetNextFireTime();
            }
        }
    }
}