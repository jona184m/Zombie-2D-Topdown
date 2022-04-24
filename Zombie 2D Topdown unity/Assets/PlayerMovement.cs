using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //laver variabler til movement
    public float moveSpeed = 5f;

    //giver adgang til spilkarakterens Rigidbody
    public Rigidbody2D rb;

    Vector2 movement;

    //da Updatefunktionen er d�rlig til physics, pga at framerate kan variere, 
    //bruger vi Update til input og ikke movement
    void Update()
    {
        //input i horisontal retning
        movement.x = Input.GetAxisRaw("Horizontal");
        //input i vertikal retning
        movement.y = Input.GetAxisRaw("Vertical");

    }

    //laver funktionen FixedUpdate, som updaterer p� en bestemt timer, istedet for per frame
    void FixedUpdate()
    {
        //bev�ger vores rigidbody til en ny position baseret p� movement og moveSpeed variablerne. 
        rb.MovePosition(rb.position +movement * moveSpeed * Time.fixedDeltaTime);

        

    }


}