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

    private Vector3[] _startposition = { new Vector3(279.9f, 22.02f, 590.1f), new Vector3(558.2f, 18.85f, 216.2f), new Vector3(758.57f, 20.22f, 686.02f) };

    // Start is called before the first frame update
    void Start()
    {
        // randomised start position
        int index = Random.Range(0, 2);
        Vector3 position = _startposition[index];
        // set start position
        transform.position = position;
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
