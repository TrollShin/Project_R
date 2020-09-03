using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SOWeapon : IWeapon
{
    public float Damage;
    public float AttackSpeed;

    public abstract void Attack(UnitTable.UnitStatus _UnitStatus, UnityEngine.Vector3 _Direction, UnityEngine.LayerMask _AttackerLayer);

    public abstract void Attack(UnitTable.UnitStatus _UnitStatus, float _Talent, UnityEngine.Vector3 _Direction, UnityEngine.LayerMask _AttackerLayer);
}
