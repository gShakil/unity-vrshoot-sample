using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // 지정된 컴포넌트가 필수이며 적용되어있지 않으면 자동으로 추가된다.
public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 20f; // 총알 속도 [m/s]
    // Start is called before the first frame update
    void Start()
    {
        //transform.forward : 총알의 앞쪽 방향(z방향)을 나타내는 단위벡터.
        // 게임 오브젝트 앞쪽 방향의 속도 벡터를 계산
        var velocity = speed * transform.forward;

        // Rigidbody 컴포넌트를 취득
        var rigidbody = GetComponent<Rigidbody>();

        // Rigidbody 컴포넌트를 사용해 시작 속도를 준다
        // VelocityChange: 지정한 속도 변화에 상당하는 힘을 가할 수 있다.
        // Rigidbody 컴포넌트가 적용되어 있어 물리 엔진에 의해 제어되기 때문에 한 번 속도를 주면 다른 힘을 가하지 않는 한 직진해서 나가게 된다.
        rigidbody.AddForce(velocity, ForceMode.VelocityChange);
    }

    void OnTriggerEnter(Collider other)
    {
        // 충돌 대상에 "OnHitBullet" 메시지
        // OnHitBullet 메시지를 받은 게임 오브젝트는 적용된 컴포넌트 전체에 대해서 OnHitBullet 이라는 이름의 함수가 있으면 그 함수를 실행합니다.
        other.SendMessage("OnHitBullet");

        // 자신의 게임 오브젝트를 제거
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
