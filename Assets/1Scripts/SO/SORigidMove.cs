using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SORigidMove", menuName = "SOMoveBehavior/SORigidMove")]
public class SORigidMove : SOMove
{
    public override void Move(Vector3 _Direction, float _Speed, GameObject _Unit)
    {
        Rigidbody2D rigid = _Unit.GetComponent<Rigidbody2D>();
        rigid.velocity = Vector3.zero;
        rigid.AddForce(_Direction * _Speed);

        if(rigid.velocity.x < 0) _Unit.GetComponent<SpriteRenderer>().flipX = true;
        else if(rigid.velocity.x > 0) _Unit.GetComponent<SpriteRenderer>().flipX = false;
    }
}
