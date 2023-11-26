using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region variables

    public Action onCoinPickup;
    public Action onDeathTrigger;

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

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.layer == 6)
        {
            onDeathTrigger?.Invoke();
        }
    }

    #endregion private functions
}
