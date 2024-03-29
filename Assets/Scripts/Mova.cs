using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mova : MonoBehaviour
{
    [SerializeField] float moveSpeed = 9.0f;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,yValue);
    }
}
