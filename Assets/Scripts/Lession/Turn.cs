using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    void Update()
    {
        //transform.rotation *= Quaternion.Euler(0, 10, 0);
        transform.Rotate(0, 5, 0); //����� ������� ����� ������� ������
        transform.RotateAround(transform.position, transform.up, 2f * Time.deltaTime); //����� �������� ������ �������� ���
    }
}