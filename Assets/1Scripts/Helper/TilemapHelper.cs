using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SocialPlatforms;
using UnityEngine.Tilemaps;

[Serializable]
public struct TileMapInfo
{
    public Tilemap Tilemap;
    public string TileMapType;
}

public class TilemapHelper : MonoBehaviour
{
    [SerializeField]
    private TileMapInfo[] TileMapInfo;

    public void SetTile(string _ThemeName)
    {
        for(int i = 0; i < TileMapInfo.Length; i++)
        {
            for(int j = TileMapInfo[i].Tilemap.cellBounds.xMin; j < TileMapInfo[i].Tilemap.cellBounds.xMax; j++)
            {
                for(int k = TileMapInfo[i].Tilemap.cellBounds.yMin; k < TileMapInfo[i].Tilemap.cellBounds.yMax; k++)
                {
                    Vector3Int localpos = new Vector3Int(j, k, 0);

                    if(TileMapInfo[i].Tilemap.HasTile(localpos))
                    {
                        TileBase tile = Resources.Load<TileBase>(String.Format("Tile/{0}/{1}", _ThemeName, TileMapInfo[i].TileMapType));
                        TileMapInfo[i].Tilemap.SetTile(localpos, tile);
                    }
                }
            }
        }
    }
}
