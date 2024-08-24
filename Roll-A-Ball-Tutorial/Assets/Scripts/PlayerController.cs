using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text CountText;
    public Text WinText;
    
    private Rigidbody rb;
    private int count;

    void Start ()
    {
        count = 0;
        rb = GetComponent<Rigidbody>();
        SetCountText();
        WinText.text = "";
    }

    //called just before performing any physics calculations
    //physics code goes here
    void FixedUpdate ()
    {

        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");


        Vector3 movement = new Vector3 (moveHorizontal,0.0f,moveVertical);

        rb.AddForce (movement * speed);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        CountText.text = "Count: " + count.ToString();
        if(count >= 13)
        {
            WinText.text = "You Win!!";
            CountText.text = "";
        }
    }
}
