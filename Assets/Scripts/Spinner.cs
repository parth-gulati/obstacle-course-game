using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotationX = 0f;
    [SerializeField] float rotationY = 0.4f;
    [SerializeField] float rotationZ = 0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationX, rotationY, rotationZ);
    }
}
