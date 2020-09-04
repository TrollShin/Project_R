using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOTestWeapon : SOWeapon
{


    public override void Attack(UnitTable.UnitStatus _UnitStatus, Vector3 _Direction, LayerMask _AttackerLayer)
    {
        throw new System.NotImplementedException();
    }

    public override void Attack(UnitTable.UnitStatus _UnitStatus, float _Talent, Vector3 _Direction, LayerMask _AttackerLayer)
    {
        throw new System.NotImplementedException();
    }
}
