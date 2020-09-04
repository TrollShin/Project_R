using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitEntity : MonoBehaviour
{
    public delegate void UnitEntityEvent();
    public event UnitEntityEvent OnSetUnit;

    public string UnitName;
    public LayerMask EnemyLayer;

    public SpriteRenderer EntitySpriteRenderer;

    public UnitTable.UnitStatus UnitStatus;

    private void Awake()
    {
        EntitySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        SetUnit(UnitName);
    }

    private void OnEnable()
    {
    }

    public virtual void SetUnit(string _UnitName)
    {
        var UnitData = GameManager.Instance.GetUnitData(_UnitName);
        UnitStatus = UnitData;

        EntitySpriteRenderer.sprite = UnitData.UnitSprite;        

        OnSetUnit?.Invoke();
    }

    public virtual void Attack(Vector3 _Direction, LayerMask _AttackLayer)
    {
        UnitStatus.Weapon.Attack(UnitStatus, _Direction, _AttackLayer);
    }

    public void Move(Vector3 _Direction)
    {
        UnitStatus.MoveBehavior.Move(_Direction, UnitStatus.MoveSpeed, gameObject);
    }

    public void GetDamaged(float _Damage)
    {

    }
}
