using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform target;
    [SerializeField] Vector3 offset;


    private void FixedUpdate()
    {
        MoveTowardsTarget();
    }

    void MoveTowardsTarget()
    {
        transform.position = Vector3.Lerp(transform.position, target.position+offset, speed * Time.fixedDeltaTime);
    }
}
