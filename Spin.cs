using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour

{
    public float speed;
    float x, sx;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(1, 0, 0));
        x = Input.GetAxis("Horizontal");
        
    }
        
}