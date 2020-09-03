using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUnitTable", menuName = "Tables/UnitTable")]
public class UnitTable : ScriptableObject
{
    [System.Serializable]
    public struct UnitStatus
    {
        public string UnitName;
        public Sprite UnitSprite;
        public float MaxHp;
        public float Damage;
        public float AttackSpeed;
        public float MoveSpeed;

        public SOWeapon Weapon;
        public SOMove MoveBehavior;
    }

    public UnitStatus[] Units;
}
