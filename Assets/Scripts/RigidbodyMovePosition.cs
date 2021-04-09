using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMovePosition : MonoBehaviour
{
    [SerializeField]
    private float force = 200;
    private Rigidbody body;

    private void Awake()
    {
        body = GetComponent<Rigidbody>();

    }

    private void Update()
    {
        body.MovePosition(transform.position + (transform.forward * Time.deltaTime));
    }

}
