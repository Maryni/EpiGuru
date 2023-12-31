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
    [SerializeField] private PointData pointData;
    [SerializeField] private LocationData locationData;

    #endregion variables


    #region properties

    public CoinData CoinData => coinData;
    public SoundData SoundData => soundData;
    public MoveData MoveData => moveData;
    public PointData PointData => pointData;
    public LocationData LocationData => locationData;

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

[Serializable]
public class PointData
{
    public List<GameObject> Points;
    public List<GameObject> CubesOnPoints;
}

[Serializable]
public class LocationData
{
    public string CountryCode;
}

#endregion Serializable classes