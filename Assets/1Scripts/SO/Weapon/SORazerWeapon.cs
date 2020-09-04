using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SORazerWeapon : SOWeapon
{
    public override void Attack(UnitTable.UnitStatus _UnitStatus, Vector3 _Direction, LayerMask _AttackerLayer)
    {
        Attack(_UnitStatus, 1, _Direction, _AttackerLayer);
    }

    public override void Attack(UnitTable.UnitStatus _UnitStatus, float _Talent, Vector3 _Direction, LayerMask _AttackerLayer)
    {
        //Razer 공격 코드       
        //Physics2D.OverlapBoxAll() 를 이용해서 범위안의 적들을 불러옴

        //불러온 적들을 데미지줌

        //LineRenderer로 이펙트
    }
}
