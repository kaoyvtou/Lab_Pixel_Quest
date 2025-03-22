using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 3;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);

        float yInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yInput * speed, rb.velocity.x);
    }
}