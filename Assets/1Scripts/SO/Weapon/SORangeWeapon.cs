using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SORangeWeapon : SOWeapon
{
    //talent 라는 수치가 투사체 및 모든 부가요소들을 결정함
    public override void Attack(UnitTable.UnitStatus _UnitStatus, Vector3 _Direction, LayerMask _AttackerLayer)
    {
        Attack(_UnitStatus, 1, _Direction, _AttackerLayer);
    }

    public override void Attack(UnitTable.UnitStatus _UnitStatus, float _Talent, Vector3 _Direction, LayerMask _AttackerLayer)
    {
        //원거리 공격 코드
        //투사체 발사 ( 파라미터로 총알 받아옴 )
        
        //공격 처리는 투사체에서 처리?
    }
}
