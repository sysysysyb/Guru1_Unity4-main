using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    // �Ѿ˰���
    public GameObject bulletFactory;

    // �߻�
    public GameObject firePosition;

    void Start()
    {
        
    }

    void Update()
    {
        // ����ڰ� �߻��ư(Ctrl)�� ������ �Ѿ� �߻��ϱ�
        // ���� ����ڰ� �߻��ư�� ������
        // �Ѿ� ���忡�� �Ѿ��� �����, �Ѿ��� �߻�(�ѱ��� ��ġ)�ϰ� �ʹ�.
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = firePosition.transform.position;
        }
    }
}
