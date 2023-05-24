using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    /*
    * public 혹은 [SerializeField]가 붙은 멤버 변수는 유니티 에디터의 Inspector 창에서 설정 변경 가능
    */

    [SerializeField] float angularVelocity = 30f; // 회전 속도의 설정

    float horizontalAngle = 0f; // 수평 방향의 회전량을 저장
    float verticalAngle = 0f; // 수직 방향의 회전량을 저장

    // Start is called before the first frame update
    void Start()
    {

    }

#if UNITY_EDITOR // 휴대 단말에서는 무효, 유니티 에디터에서만 유효.
    // Update is called once per frame
    void Update()
    {

        /*
        * Input.GetAxis : 축의 이름을 지정해 입력값을 취득하는 함수.
        [Edit] -> [Project Settings]를 클릭해 나온 화면에서 [Input~] 항목을 클릭하여 설정 가능

        * Time.deltaTime: 앞 프레임으로부터 경과 시간 반환.

        * Mathf.Clamp: 값을 범위 내로 넣는 처리.
        */
        //입력에 따라 회전량을 취득
        var horizontalRotation = Input.GetAxis("Horizontal") *
            angularVelocity * Time.deltaTime;
        var verticalRotation = -Input.GetAxis("Vertical") *
            angularVelocity * Time.deltaTime;

        // 회전량을 갱신
        horizontalAngle += horizontalRotation;
        verticalAngle += verticalRotation;

        // 수직 방향은 너무 회전하지 않게 제한
        verticalAngle = Mathf.Clamp(verticalAngle, -80f, 80f);

        // Transform 컴포넌트에 회전량을 적용한다.
        transform.rotation = Quaternion.Euler(verticalAngle, horizontalAngle, 0f);
    }
#endif

}
