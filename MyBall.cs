using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;

    // Start is called before the first frame update
    void Start()
    {

        rigid = GetComponent<Rigidbody>();  // GetComponent<T> : �ڽ��� TŸ�� ������Ʈ�� ������
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
        // #1. �ӷ� �ٲٱ�
        // rigid.velocity = Vector3.forward; // RigidBody ���� �ڵ�� FixedUpdate�� �ۼ�!

        // #2. ���� ���ϱ� 
        /*if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 
                                  0,
                                  Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);*/

        // #3. ȸ����
        /*rigid.AddTorque(Vector3.up);*/
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
