using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3 (8, 1.5f, 0);
    // Update is called once per frame
    void Update()
    {
        //1.MoveTowards (단순 등속 운동) --> target 지점으로 등속 이동
        /*
        transform.position =
            Vector3.MoveTowards(transform.position
                             , target, 2f); 

        //2.SmoothDamp (미끄러지듯이 감속 운동)  --> 목표 지점 근처에서 감속 이동
        Vector3 velo = Vector3.up * 50;

        transform.position =
            Vector3.SmoothDamp(transform.position
                                , target, ref velo, 1f); 
        

        //3.Lerp (선형 보간)
        transform.position =
            Vector3.Lerp(transform.position
                                , target, 0.05f); */

        //4.Slerp (구면 선형 보간)
        transform.position =
            Vector3.Slerp(transform.position
                                , target, 0.05f);
    }
}
