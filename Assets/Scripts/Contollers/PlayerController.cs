using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region variables

    public Action onCoinPickup;

    #endregion variables
    
    #region private functions
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>())
        {
            other.GetComponent<Coin>().Play();
            other.gameObject.SetActive(false);
            Data.instance.DynamicData.CoinData.pickupValue++;
            onCoinPickup?.Invoke();
        }
    }

    #endregion private functions
}
