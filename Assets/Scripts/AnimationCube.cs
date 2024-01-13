using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCube : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, _speed * Time.deltaTime);
    }
}
