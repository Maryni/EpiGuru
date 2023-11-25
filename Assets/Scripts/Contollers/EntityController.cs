using System;
using System.Collections.Generic;
using UnityEngine;

public class EntityController : MonoBehaviour
{
    #region variables

    private List<GameObject> coins; //will be replaced on ObjectPool when it needed

    #endregion variables

    #region public functions

    public List<GameObject> GetCoins() => coins;

    #endregion public functions

    #region private functions

    private void Start()
    {
        GetData();
    }

    private void GetData()
    {
        coins = Data.instance.DynamicData.CoinData.Coins;
    }

    #endregion private functions
}
