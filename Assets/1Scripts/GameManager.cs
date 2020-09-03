using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public UnitTable UnitTable;
    

    private DataAssetManager DataAsset;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DataAsset = new DataAssetManager();
            DataAsset.Init(UnitTable);
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public UnitTable.UnitStatus GetUnitData(string _UnitName)
    {
        return DataAsset.GetUnitStatus(_UnitName);
    }
}
