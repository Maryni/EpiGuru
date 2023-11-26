using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSwicher : MonoBehaviour
{
    [SerializeField] private GameObject webview;
    private void Update()
    {
        var code = Data.instance.DynamicData.LocationData.CountryCode;
        if (code != null && code == "UA")
        {
            webview.SetActive(false);
        }
    }
    
}
