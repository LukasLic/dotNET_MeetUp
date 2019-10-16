using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    [SerializeField]
    private float speed = 4f;
    [SerializeField]
    private float jumpForce = 4f;
    [SerializeField]
    private float jumpTime = 4f;

    private float jumpTimer;

    private Rigidbody rigid;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody>();
        jumpTimer = jumpTime;
    }
	
	// Update is called once per frame
	void Update () {

        // Move
        var x = Input.GetAxisRaw("Horizontal");
        var movement = new Vector3(x, 0f) * Time.deltaTime * speed;

        rigid.MovePosition(transform.position + movement);

        // Jump
        jumpTimer += Time.deltaTime;

        if (Input.GetButtonDown("Jump") && jumpTimer >= jumpTime)
        {
            Debug.Log(gameObject.name + ": jumped.");
            rigid.AddForce(Vector3.up * jumpForce * 80f);
            jumpTimer = 0f;
        }
	}
}
