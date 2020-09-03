using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataAssetManager : MonoBehaviour
{
    private UnitTable UnitTable;

    private Dictionary<string, UnitTable.UnitStatus> UnitDictionary;

    public void Init(UnitTable _UnitTable)
    {
#if UNITY_EDITOR
        if (_UnitTable == null)
        {
            Debug.LogError("UnitTable이 없다");
            return;

        }
#endif
        UnitTable = _UnitTable;
        UnitDictionary = new Dictionary<string, UnitTable.UnitStatus>();

        for(int i = 0; i < UnitTable.Units.Length; i++)
        {
            UnitDictionary.Add(UnitTable.Units[i].UnitName, UnitTable.Units[i]);
        }
    }

    public UnitTable.UnitStatus GetUnitStatus(string _UnitName)
    {
#if UNITY_EDITOR
        if(!UnitDictionary.ContainsKey(_UnitName))
        {
            Debug.LogError("잘못된 UnitName");
        }
#endif

        UnitTable.UnitStatus result;

        UnitDictionary.TryGetValue(_UnitName, out result);
        return result;
    }
}
