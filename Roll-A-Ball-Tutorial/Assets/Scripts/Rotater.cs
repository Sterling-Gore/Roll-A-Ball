using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float rotate_speed;
    
    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime smoothes out any frame errors that will happen with different frame rates
        transform.Rotate (new Vector3 (15,30,45) * Time.deltaTime * rotate_speed );
    }
}
