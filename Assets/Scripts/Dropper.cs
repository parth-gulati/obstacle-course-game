using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer rendera;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    [SerializeField] float timeToWait = 3f;
    void Start()
    {
        rendera = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        
        rendera.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait){
            rigidBody.useGravity = true;
            rendera.enabled = true;
        }
    }
}
