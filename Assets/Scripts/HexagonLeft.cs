using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonLeft : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform
            .Rotate(Vector3.forward, 0.2f);       // Вращение | Вокруг вектора 3 | (Z) Градусы
    }
}
