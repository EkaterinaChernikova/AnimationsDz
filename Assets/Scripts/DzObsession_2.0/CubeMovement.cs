using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _offset = -0.01f;

    private void Update()
    {
        var positionForward = transform.position;
        positionForward.z += _offset;
        transform.position = positionForward;

        transform.Rotate(0, _speed, 0);

        transform.localScale += new Vector3(_speed, _speed, _speed) * Time.deltaTime;
    }
}
