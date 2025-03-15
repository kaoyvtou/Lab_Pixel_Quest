using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviour2 : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 5;


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
        private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        switch (collision.tag)
        {
            case "Win":
                {
                    break;
                }
            case "Lose":
                {
                    break;
                }
            case "Death":
                {
                    string LV2 = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(LV2);
                    break;
                }
            case "Finish2":
                {
                    SceneManager.LoadScene("LV3");
                    break;
                }
            case "Teleport":
                {
                    break;
                }
        }
    }
}
