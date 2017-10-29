using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    public joystick joystick;   //조이스틱 스크립트
    public float MoveSpeed;     //플레이어 이동속도
    
    private Vector3 _moveVector; //플레이어 이동벡터
    private Transform _transform;
    public float distance;

   
    void Start()
    {
        _transform = transform;      //Transform 캐싱
        _moveVector = Vector3.zero;  //플레이어 이동벡터 초기화
    }

    void Update()
    {
        //터치패드 입력 받기
        HandleInput();
    }

    void FixedUpdate()
    {
        //플레이어 이동
        Move();

        if (_moveVector.x < 0)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (_moveVector.x > 0)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }

    public void HandleInput()
    {
        _moveVector = PoolInput();
    }

    public Vector3 PoolInput()
    {
        float h = joystick.GetHorizontalValue();
        float v = joystick.GetVerticalValue();
        Vector3 moveDir = new Vector3(h, v, 0).normalized;

        return moveDir;
    }

    public void Move()
    {
        Vector3 movedir = _moveVector * MoveSpeed * Time.deltaTime;
        _transform.Translate(movedir);
        distance += movedir.magnitude;
    }
}
