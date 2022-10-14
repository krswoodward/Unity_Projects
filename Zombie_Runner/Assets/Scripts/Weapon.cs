
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public float damage = 10f;
    public float range = 100f;

    public GameObject rayPoint;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(rayPoint.transform.position, rayPoint.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
