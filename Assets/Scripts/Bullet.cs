using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // �ӵ� ����
    public float speed = 10;

    void Start()
    {
        
    }

    void Update()
    {
        // ������ ��� �̵��ϱ�
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
