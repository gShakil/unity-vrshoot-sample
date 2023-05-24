using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // OnHitBullet 메시지로부터 호출되는 것을 상정
    void OnHitBullet()
    {
        // 자신의 게임 오브젝트를 제거
        Destroy(gameObject);
    }
    
}
