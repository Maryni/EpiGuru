using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    #region variables

    [SerializeField] private Dictionary<SoundType,AudioClip> sounds = new Dictionary<SoundType, AudioClip>();

    #endregion variables

    #region public functions

    public void SetSound(GameObject target, SoundType soundType)
    {
        GetData();
        target.GetComponent<AudioSource>().clip = sounds[soundType];
    }
    
    public void SetSound(List<GameObject> targets, SoundType soundType)
    {
        GetData();
        
        foreach (var temp in targets)
        {
            temp.GetComponent<AudioSource>().clip = sounds[soundType];
        }
    }

    #endregion public functions

    #region private functions

    // private void Start()
    // {
    //     GetData();
    // }

    private void GetData()
    {
        var list = Data.instance.DynamicData.SoundData.Clips;
        
        for (int i = 0; i < list.Count; i++)
        {
            sounds.Add(SoundType.Coin, list[i]);
        } 
    }

    #endregion private functions
}
