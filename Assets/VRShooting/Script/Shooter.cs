using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab; // 총알 프리팹
    [SerializeField] Transform gunBarrelEnd; // 총구 (총알의 발사 위치)
    [SerializeField] ParticleSystem gunParticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //입력에 따라 총알을 발사한다
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        //Instantiate : 게임 오브젝트를 복제하는 함수.
        // 여기서는 프리팹을 복제하고 총구의 위치와 방향을 지정해 총알을 생선한다.
        Instantiate(bulletPrefab, gunBarrelEnd.position, gunBarrelEnd.rotation);

        gunParticle.Play();
    }
}
