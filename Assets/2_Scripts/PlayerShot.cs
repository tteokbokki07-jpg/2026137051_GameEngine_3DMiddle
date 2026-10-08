using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShot : MonoBehaviour
{
    public GameObject bulletPrefab; //총알 프리팹
    public Transform firePoint; //총알 발사 위치
    public float bulletSpeed = 20f; //총알 속도
    public float fireCooldown = 0.2f; //연사 속도

    float lastFireTime = -999f; //마지막 발사 시간

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnAttack(InputValue value)
    {
        if (Time.timeScale == 0f) return; //게임 일시정지 시 공격 무시
        if (Time.time < lastFireTime + fireCooldown) return; //연사 속도 제한
        lastFireTime = Time.time; //마지막 발사 시간 업데이트

        //firePoint 위치 기반 총알 생성
        GameObject bullet =Instantiate
            (bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = firePoint.forward * bulletSpeed; //총알 발사
    }

}
