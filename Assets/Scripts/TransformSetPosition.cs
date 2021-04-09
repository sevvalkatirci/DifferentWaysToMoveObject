using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSetPosition : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.position += transform.forward * Time.deltaTime;
    }

}
