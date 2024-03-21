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
        // ������Ʈ�� ����. Ȥ��, ��Ģ�� �µ��� ��ġ.
        Debug.Log( name + " is Dead!");
    }
    // Battle Method (Tail)

    // Move Method (Head)
    public void Move(ArrayList _path)
    {
        // findWay() �Լ��� ��ȯ�� _path �迭�� ����� ��� �̵��մϴ�;
    }

    public void findWay()
    {
        // movePoint ���� �׸��带 �����ϰ�, ������ ���� ���� �ִ� Grid�� �� �� �ִ� ��θ� ã���ϴ�.;
        // Update �Ǵ� fixedUpdate �޼��� ������ ���; �� �����Ӹ��� �̵���θ� �׷������� ���Դϴ�.
        // ������ �̵��� ������ ���, ��θ� �迭(_path)�� ����� Move()�޼��忡�� �����մϴ�.
    }
    // Move Method (Tail)
}
