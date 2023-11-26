using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region variables

    public Action onCoinPickup;
    public Action onDeathTrigger;
    [SerializeField] private AudioSource audioSource;

    #endregion variables
    
    #region private functions
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            audioSource.Play();
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
