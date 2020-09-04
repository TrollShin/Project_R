using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="NewWeaponTable", menuName ="Tables/WeaponTable")]
public class WeaponTable : ScriptableObject
{
    public List<SOWeapon> Weapons;
}
