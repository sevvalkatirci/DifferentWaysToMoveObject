using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodySetVelocity : MonoBehaviour
{
    [SerializeField]
    private float force = 400;
    private Rigidbody body;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
        body.velocity = transform.forward * force * Time.deltaTime;
    }

}
