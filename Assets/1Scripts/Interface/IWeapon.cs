public interface IWeapon
{
    void Attack(UnitTable.UnitStatus _UnitStatus, UnityEngine.Vector3 _Direction, UnityEngine.LayerMask _AttackerLayer);

    void Attack(UnitTable.UnitStatus _UnitStatus, float _Talent, UnityEngine.Vector3 _Direction, UnityEngine.LayerMask _AttackerLayer);
}
