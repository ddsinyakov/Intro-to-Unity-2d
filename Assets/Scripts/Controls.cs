using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody2D.AddForce(Vector2.up * 100);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _rigidbody2D.AddTorque(50);
            _rigidbody2D.AddForce(new Vector2(1, 3) * 100);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            _rigidbody2D.AddTorque(-50);
            _rigidbody2D.AddForce(new Vector2(-1, 3) * 100);
        }

        
    }
}
