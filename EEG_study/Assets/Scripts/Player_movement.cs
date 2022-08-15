using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{

    // PLAYER MOVEMENT
    // variables for player movement
    [SerializeField]
    public float _moveSpeed = 7f;

    [SerializeField]
    public float _turnSpeed = 2f;


    // Start is called before the first frame update
    void Start()
    {
        // sets first position
        transform.position = new Vector3(305.76f, 22.02f, 463.95f);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        //  ROTATION - horizontal player movement: rotates the player on the y-axis
        float horizontal = Input.GetAxis("Horizontal");

        if (horizontal > 0)
        {
            transform.Rotate(0, horizontal * _turnSpeed, 0);
        }
        else if (horizontal < 0)
        {
            transform.Rotate(0, horizontal * _turnSpeed, 0);
        }

        // MOVEMENT - vertical player movement: moves player forward or back
        float vertical = Input.GetAxis("Vertical");

        if (vertical > 0)
        {
            transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        }
        else if (vertical < 0)
        {
            transform.Translate(Vector3.back * _moveSpeed * Time.deltaTime);
        }
    }
}
