using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationShpere : MonoBehaviour
{
    private float _offset = -0.01f;

    private void Update()
    {
        var positionForward = transform.position;
        positionForward.z += _offset;
        transform.position = positionForward;
    }
}
