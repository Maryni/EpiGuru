using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    #region variables

    [SerializeField] private StaticData staticData;
    [SerializeField] private DynamicData dynamicData;

    public StaticData StaticData => staticData;
    public DynamicData DynamicData => dynamicData;

    #endregion variables
    
    #region Singleton

    public static Data instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }
    }

    #endregion Singleton
    
}
