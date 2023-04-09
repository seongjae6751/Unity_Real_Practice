using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3 (8, 1.5f, 0);
    // Update is called once per frame
    void Update()
    {
        //1.MoveTowards (�ܼ� ��� �) --> target �������� ��� �̵�
        /*
        transform.position =
            Vector3.MoveTowards(transform.position
                             , target, 2f); 

        //2.SmoothDamp (�̲��������� ���� �)  --> ��ǥ ���� ��ó���� ���� �̵�
        Vector3 velo = Vector3.up * 50;

        transform.position =
            Vector3.SmoothDamp(transform.position
                                , target, ref velo, 1f); 
        

        //3.Lerp (���� ����)
        transform.position =
            Vector3.Lerp(transform.position
                                , target, 0.05f); */

        //4.Slerp (���� ���� ����)
        transform.position =
            Vector3.Slerp(transform.position
                                , target, 0.05f);
    }
}
