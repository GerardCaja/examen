using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float playerSpeed = 5.5f;
    public float jumpForce = 10f;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rBody;
    private GroundSensor sensor;
    float hor;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rBody = GetComponent<Rigidbody2D>();
        sensor = GetComponentInChildren<GroundSensor>();
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(hor * playerSpeed * Time.deltaTime, 0, 0);

        if(hor < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if(hor > 0)
        {
            spriteRenderer.flipX = false;
        }
        else
        {

        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(sensor.isGrounded)
            {
                rBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }
    }
}
