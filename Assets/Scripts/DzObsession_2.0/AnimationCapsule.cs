using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCapsule : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.localScale += new Vector3(_speed, _speed, _speed) * Time.deltaTime;
    }
}
