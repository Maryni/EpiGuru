using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class DynamicData
{
    #region variables

    [SerializeField] private CoinData coinData;
    [SerializeField] private SoundData soundData;
    [SerializeField] private MoveData moveData;

    #endregion variables


    #region properties

    public CoinData CoinData => coinData;
    public SoundData SoundData => soundData;
    public MoveData MoveData => moveData;

    #endregion properties
}

#region Serializable classes

[Serializable]
public class CoinData
{
    public List<GameObject> Coins;
    public int pickupValue;
}

[Serializable]
public class SoundData
{
    public List<AudioClip> Clips;
}

[Serializable]
public class MoveData
{
    public float Speed;
}

#endregion Serializable classes
