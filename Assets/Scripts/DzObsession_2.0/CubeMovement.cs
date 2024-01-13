using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        var positionForward = transform.position;
        positionForward.z += -0.01f;
        transform.position = positionForward;

        transform.Rotate(0, _speed, 0);

        transform.localScale += new Vector3(_speed, _speed, _speed) * Time.deltaTime;
    }
}
