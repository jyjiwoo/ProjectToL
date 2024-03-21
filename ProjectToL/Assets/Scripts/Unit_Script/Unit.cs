using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour
{
    [SerializeField]
    private float HP;
    private float moveSpeed;
    private float movePoint;
    private float damage;
    private float range;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Methods Under

    // Battle Method (Head)
    public void Attack(Unit opponent)
    {
        opponent.isDamaged(damage);
    }// Trigger opponent .isDamage()

    public void isDamaged(float _damage)
    {
        if(_damage >= HP) { isDead(); }
    }

    public void isDead()
    {
        // 오브젝트를 제거. 혹은, 규칙에 맞도록 조치.
        Debug.Log( name + " is Dead!");
    }
    // Battle Method (Tail)

    // Move Method (Head)
    public void Move(ArrayList _path)
    {
        // findWay() 함수가 반환한 _path 배열에 저장된 길로 이동합니다;
    }

    public void findWay()
    {
        // movePoint 내의 그리드를 조사하고, 유저가 현재 보고 있는 Grid로 갈 수 있는 경로를 찾습니다.;
        // Update 또는 fixedUpdate 메서드 내에서 사용; 매 프레임마다 이동경로를 그래픽으로 보입니다.
        // 유저가 이동을 결정할 경우, 경로를 배열(_path)로 만들어 Move()메서드에게 전달합니다.
    }
    // Move Method (Tail)
}
