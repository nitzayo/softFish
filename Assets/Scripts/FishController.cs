using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FishController : MonoBehaviour {

    Rigidbody2D rigid;
    public float speed = 0;
    public float shrink = 0;

    public Transform camera;

    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("w"))
        {
            rigid.velocity += new Vector2(0, speed);
        }
        if (Input.GetKeyDown("s"))
        {
            rigid.velocity += new Vector2(0, -speed);
        }
        if (Input.GetKeyDown("d"))
        {
            rigid.velocity += new Vector2(speed, 0);
        }
        if (Input.GetKeyDown("a"))
        {
            rigid.velocity += new Vector2(-speed, 0);
        }
        if (Input.GetKeyDown("q"))
        {
            transform.localScale += new Vector3(-shrink, -shrink, 1);
        }
        if (Input.GetKeyDown("e"))
        {
            transform.localScale += new Vector3(shrink, shrink, 1);
        }
        camera.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, camera.localPosition.z) ;
    }
}
