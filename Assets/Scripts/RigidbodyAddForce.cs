using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyAddForce : MonoBehaviour
{
    [SerializeField]
    private int force = 200;
    private Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        body.AddForce(transform.forward * force * Time.deltaTime);
    }

}
