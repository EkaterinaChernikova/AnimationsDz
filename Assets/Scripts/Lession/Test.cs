using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection; //Для того, что отображалось в инспекторе и его можно было менять

    void Update()
    {
        //var nextPosition = transform.position; //localPosition вместо position
        //nextPosition.z += 0.05f;
        //transform.position = nextPosition; //localPosition вместо position

        //transform.position += _movementDirection;
        transform.Translate(_movementDirection, Space.World);
    }
}
