using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    private Vector3 _position;
    private GameObject _bird;
    private Rigidbody2D _birdRB;

    // Start is called before the first frame update
    void Start()
    {
        _position = transform.parent.gameObject.transform.position;
        _bird = GameObject.Find("Bird");
        _birdRB = _bird.GetComponent<Rigidbody2D>();

        this.transform.RotateAround(_position, Vector3.forward, 50f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.RotateAround(_position, Vector3.forward, .1f);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.RotateAround(_position, Vector3.back, .1f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _birdRB.AddForce((this.transform.position - _position) * 500);
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            _birdRB.velocity = Vector3.zero;
            _bird.transform.position = _position;
        }
    }
}
