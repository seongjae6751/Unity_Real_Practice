using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Start()
    {
        Vector3 vec = new Vector3(5, 5, 5);
        transform.Translate(vec); // ���� ���� ���� ��ġ�� ���ϴ� �Լ�
        // Transform tr;  -> �ʿ� ���� ������Ʈ�� ���� transform�� �׻� ������ ����

    }

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime);  // deltaTime ���� �������� ������ ũ��, �������� ������ ����
        transform.Translate(vec);   
         
    }
    // Start is called before the first frame update
    /*
    void Awake()
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    private void OnEnable()
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
    }

    void Start()
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    void FixedUpdate()
    {
        Debug.Log("�̵�~");
    }
    */

    /*
    void Update()
    {
        
        
        if (Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.GetButton("Horizontal")) {
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetButton("Vertical")) {
            Debug.Log("�� �̵� ��..." + Input.GetAxisRaw("Vertical"));
        }
    */

    /*
    if (Input.GetKeyDown(KeyCode.Return))
        Debug.Log("�������� �����Ͽ����ϴ�.");
    if (Input.GetKey(KeyCode.LeftArrow))
        Debug.Log("�������� �̵� ��");
    if (Input.GetKeyUp(KeyCode.RightArrow))
        Debug.Log("������ �̵��� ���߾����ϴ�.");
    if (Input.GetButtonDown("Jump"))
        Debug.Log("����");
    if (Input.GetButton("Jump"))
        Debug.Log("���� ������ ��");
    if (Input.GetButtonUp("Jump"))
        Debug.Log("���� ����!!");
    */


    /*
    void LateUpdate()
    {
        Debug.Log("����ġ ȹ��.");
    }

    void OnDisable()
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }
    void OnDestroy()
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }
    */
}
