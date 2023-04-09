using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Start()
    {
        Vector3 vec = new Vector3(5, 5, 5);
        transform.Translate(vec); // 벡터 값을 현재 위치에 더하는 함수
        // Transform tr;  -> 필요 없다 오브젝트는 변수 transform을 항상 가지고 있음

    }

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime);  // deltaTime 값은 프레임이 적으면 크고, 프레임이 많으면 적음
        transform.Translate(vec);   
         
    }
    // Start is called before the first frame update
    /*
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    private void OnEnable()
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }

    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate()
    {
        Debug.Log("이동~");
    }
    */

    /*
    void Update()
    {
        
        
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.GetButton("Horizontal")) {
            Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal"));
        }
        if (Input.GetButton("Vertical")) {
            Debug.Log("종 이동 중..." + Input.GetAxisRaw("Vertical"));
        }
    */

    /*
    if (Input.GetKeyDown(KeyCode.Return))
        Debug.Log("아이템을 구입하였습니다.");
    if (Input.GetKey(KeyCode.LeftArrow))
        Debug.Log("왼쪽으로 이동 중");
    if (Input.GetKeyUp(KeyCode.RightArrow))
        Debug.Log("오른쪽 이동을 멈추었습니다.");
    if (Input.GetButtonDown("Jump"))
        Debug.Log("점프");
    if (Input.GetButton("Jump"))
        Debug.Log("점프 모으는 중");
    if (Input.GetButtonUp("Jump"))
        Debug.Log("슈퍼 점프!!");
    */


    /*
    void LateUpdate()
    {
        Debug.Log("경험치 획득.");
    }

    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }
    void OnDestroy()
    {
        Debug.Log("플레이어 대이터를 해제하였습니다.");
    }
    */
}
