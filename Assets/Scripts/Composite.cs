using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Composite : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.centerOfMass = new Vector3(1, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
