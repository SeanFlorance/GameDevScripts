using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class SaveData
{
    public Vector3 playerPosition;
    public string mapBoundry;
    public List<InventorySaveData> inventorySaveData;
}
