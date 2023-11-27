using System.Collections;
using System.Collections.Generic;
using Castle.Core.Internal;
using UnityEngine;

public class GameSwicher : MonoBehaviour
{
    [SerializeField] private SampleWebView webview;
    [SerializeField] private GameObject webviewGameobject;
    
    private void Update()
    {
        if (webviewGameobject != null)
        {
            webview = webviewGameobject.GetComponent<SampleWebView>();
        }
        
        var code = Data.instance.DynamicData.LocationData.CountryCode;
        Debug.Log($"code = {code}");
        if ( code != "UA" && !code.IsNullOrEmpty())
        {
            webview.enabled=true;
        }
    }
    
}
