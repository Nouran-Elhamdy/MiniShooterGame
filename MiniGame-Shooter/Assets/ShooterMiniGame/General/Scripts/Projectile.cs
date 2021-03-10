using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(20f, 70f)] public float bulletAngle;
    public virtual void FireProjectile(Vector3 startPosition, Vector3 targetPosition, GameObject projectedObject)
    {
        Vector3 startPos = projectedObject.transform.position;
        Vector3 target = targetPosition;
        float distance = Vector3.Distance(startPos, target);

        transform.LookAt(target);

        float initialVeclocity = Mathf.Sqrt(distance * -Physics.gravity.y / (Mathf.Sin(Mathf.Deg2Rad * bulletAngle * 2f)));
        float yVelocity, zVelocity;

        yVelocity = initialVeclocity * Mathf.Sin(Mathf.Deg2Rad * bulletAngle);
        zVelocity = initialVeclocity * Mathf.Cos(Mathf.Deg2Rad * bulletAngle);


        Vector3 localVelocity = new Vector3(0f, yVelocity, zVelocity);
        Vector3 globalVelocity = transform.TransformVector(localVelocity);

        projectedObject.gameObject.GetComponent<Rigidbody>().velocity = globalVelocity;
    }
}
