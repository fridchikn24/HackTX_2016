using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private const string ANIM_FLOAT_VELOCITY = "VELOCITY";

    public float moveForce = 200;
    public float maxSpeed = 10;
    public float frictionForce = 50;

    // Use this for initialization
    void Start () {
        GetComponent<Rigidbody2D>().drag = 10;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // FixedUpdate runs at a certain pace in real-time
    void FixedUpdate()
    {

        // Cache the directional inputs
        float axisHorz = Input.GetAxis("Horizontal");
        float axisVert = Input.GetAxis("Vertical");

        // If the player is inputting a direction, move in that direction up to the move speed
        if (axisHorz * GetComponent<Rigidbody2D>().velocity.x < maxSpeed)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * axisHorz * moveForce);
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * axisVert * moveForce);
        }
    }
}
