using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float speed = 10f;

    private void Update()
    {
        float angle = Mathf.Rad2Deg * speed * Time.deltaTime;
        transform.Rotate(Vector3.up, angle, Space.World);
    }
}
