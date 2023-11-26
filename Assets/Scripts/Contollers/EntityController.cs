using System.Collections.Generic;
using UnityEngine;

public class EntityController : MonoBehaviour
{
    #region variables
    
    private List<GameObject> coins; //will be replaced on ObjectPool when it needed
    private List<GameObject> points;

    #endregion variables

    #region public functions

    public List<GameObject> GetCoins()
    {
        GetData();
        return coins;
    }
    
    #endregion public functions

    #region private functions

    // private void Start()
    // {
    //     GetData();
    // }

    private void GetData()
    {
        coins = Data.instance.DynamicData.CoinData.Coins;
        points = Data.instance.DynamicData.PointData.Points;
    }

    #endregion private functions
}
