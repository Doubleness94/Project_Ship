using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : LivingEntity
{
    public float hAxis { get; private set; }
    public float vAxis { get; private set; }
    public float moveSpeed;
    public bool isMove = false;
    private Rigidbody playerRigid;
    public Vector3 moveVec;

    private void Awake()
    {
        playerRigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (dead)
        {
            hAxis = 0;
            vAxis = 0;
            return;
        }

        hAxis = Input.GetAxisRaw("Horizontal");
        vAxis = Input.GetAxisRaw("Vertical");

        if(moveVec != Vector3.zero)
        {
            isMove = true;
        }
        else
        {
            isMove = false;
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        moveVec = new Vector3(hAxis, 0, vAxis).normalized;
        transform.position += moveVec * moveSpeed * Time.deltaTime;
    }

    protected override void OnEable()
    {
        base.OnEable();
    }

    public override void Die()
    {
        base.Die();
    }

    public override void RestoreHealth(float newHealth)
    {
        base.RestoreHealth(newHealth);
    }

    public override void OnDamage(float damage, Vector3 hitPoint, Vector3 hitNormal)
    {
        if (!dead)
        {
            //�ִϸ��̼�, ����, ����Ʈ ���
        }
        base.OnDamage(damage, hitPoint, hitNormal);
    }

    private void OnTriggerEnter(Collider other)
    {
        //������, ����ġ ����
        if (!dead)
        {

        }
    }
}
