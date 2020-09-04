using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : UnitEntity
{
    public Joystick MovementJoystick;
    public Joystick AttackJoystick;

    private Coroutine AttackCoroutine;
    private Coroutine MoveCoroutine;

    private float Talent;

    private void Awake()
    {
        AttackJoystick.OnJoyStickDown += OnAttackStart;
        AttackJoystick.OnJoyStickUp += OnAttackStop;

        MovementJoystick.OnJoyStickDown += OnMoveStart;
        MovementJoystick.OnJoyStickUp += OnMoveStop;
    }

    public void InitUnit()
    {
        Talent = 1;
        SetUnit(UnitName);
    }

    public override void Attack(Vector3 _Direction, LayerMask _AttackerLayer)
    {
        UnitStatus.Weapon.Attack(UnitStatus, Talent, _Direction, _AttackerLayer);        
    }

    IEnumerator CAttack()
    {
        Attack(AttackJoystick.Direction, gameObject.layer);

        yield return Yielders.Get(1 / UnitStatus.AttackSpeed);

        MoveCoroutine = StartCoroutine(CAttack());
    }

    IEnumerator CMove()
    {
        Move(MovementJoystick.Direction);

        yield return Yielders.WaitForFixedUpdate;

        AttackCoroutine = StartCoroutine(CMove());
    }

    private void OnAttackStart()
    {
        AttackCoroutine = StartCoroutine(CAttack());
    }

    private void OnAttackStop()
    {
        StopCoroutine(AttackCoroutine);
    }

    private void OnMoveStart()
    {
        MoveCoroutine = StartCoroutine(CAttack());
    }

    private void OnMoveStop()
    {
        StopCoroutine(MoveCoroutine);
    }
}
