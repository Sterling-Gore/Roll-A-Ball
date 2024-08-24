using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //references to the player
    public GameObject player;

    //the distance between the camera and the player
    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        //transform position of camera - transform position of player 
        offset = transform.position - player.transform.position;
        
    }

    // LateUpdate is for follow cameras, procedural animation, and gathering last known states
    //runs every frame, but is guranteed to run after all items have been processed in update
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
        
    }
}
