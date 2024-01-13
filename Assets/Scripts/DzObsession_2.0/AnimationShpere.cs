using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationShpere : MonoBehaviour
{
    void Update()
    {
        var positionForward = transform.position;
        positionForward.z += -0.01f;
        transform.position = positionForward;
    }
}
