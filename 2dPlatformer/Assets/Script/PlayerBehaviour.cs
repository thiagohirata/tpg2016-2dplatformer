using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour {

    float jumpSpeed = 10;
    float movementSpeed = 5;
	
	void FixedUpdate () {
        Rigidbody2D rigidBody2D = this.GetComponent<Rigidbody2D>();
        Vector2 velocidade = rigidBody2D.velocity;
        if (Input.GetButtonDown("Jump"))
        {
            velocidade.y = jumpSpeed;
        }
        if (Input.GetAxis("Horizontal") != 0)
        {
            velocidade.x = movementSpeed * Input.GetAxis("Horizontal");
        }
        rigidBody2D.velocity = velocidade;
    }
}
