using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : UnitEntity
{
    public Joystick MovementJoystick;
    public Joystick AttackJoystick;

    private UnitEntity UnitEntity;

    private float Talent;

    private void Awake()
    {
        UnitEntity = GetComponent<UnitEntity>();
    }

    public void InitUnit()
    {
        Talent = 1;
        SetUnit(UnitName);
    }

    public override void Attack(Vector3 _Direction, LayerMask _AttackerLayer)
    {
        UnityStatus.Weapon.Attack(UnityStatus, Talent, _Direction, _AttackerLayer);        
    }
}
