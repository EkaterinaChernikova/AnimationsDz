using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection; //��� ����, ��� ������������ � ���������� � ��� ����� ���� ������

    void Update()
    {
        //var nextPosition = transform.position; //localPosition ������ position
        //nextPosition.z += 0.05f;
        //transform.position = nextPosition; //localPosition ������ position

        //transform.position += _movementDirection;
        transform.Translate(_movementDirection, Space.World);
    }
}
