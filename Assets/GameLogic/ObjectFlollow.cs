using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectFlollow : MonoBehaviour
{
    public Transform target;         


    void Update()
    {
        if (target != null)
        {
            FollowTarget();
        }
    }

    void FollowTarget()
    {

        transform.position = target.position;

    }
}
