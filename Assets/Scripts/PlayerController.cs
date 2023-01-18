using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int playerHealth = 3;
    public float playerSpeed = 5.5f; 
    public float JumpForce = 10;
    string texto = "Hello World"; 
    private GroundSensor sensor;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rBody;

    float horizontal;  
    // Start is called before the first frame update
    void Start()
    {
      spriteRenderer = GetComponent<SpriteRenderer>();
      rBody = GetComponent<Rigidbody2D>();
      sensor = GameObject.Find("Ground Sensor").GetComponent<GroundSensor>();
      playerHealth = 10; 
      Debug.Log(texto);  
    }

    // Update is called once per frame
    void Update()
    {
      horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal, 0, 0)* playerSpeed* Time.deltaTime;
        if(horizontal < 0)
        {
          spriteRenderer.flipX = true;
        }
        else if(horizontal > 0)
        {
          spriteRenderer.flipX = false;

        }
        if(Input.GetButtonDown("Jump")&& sensor.isGrounded)
        {
          rBody.AddForce(Vector2.up * JumpForce,ForceMode2D.Impulse);
        }

    }
}
