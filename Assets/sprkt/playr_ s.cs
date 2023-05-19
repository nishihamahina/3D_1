using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playr_s : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");
        var movement = new Vector3(Horizontal, 0, Vertical);
        
        rb.AddForce(movement * 3.0f);
    }
}
