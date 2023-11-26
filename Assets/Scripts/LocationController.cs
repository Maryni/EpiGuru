using UnityEngine;
using System.Net;

public class LocationController : MonoBehaviour
{
    private void Start()
    {
        ShowIp();
    }
    
    private void ShowIp()
    {
        string ipAddress = GetIPAddress();
        string countryCode = GetCountry(ipAddress);

        Debug.Log("Country: " + countryCode);
        Data.instance.DynamicData.LocationData.CountryCode = countryCode;
    }

    private string GetIPAddress()
    {
        string ipAddress = "";

        try
        {
            using (WebClient client = new WebClient())
            {
                ipAddress = client.DownloadString("https://api64.ipify.org?format=text");
                Debug.Log($"ip = {ipAddress}");
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error by getting IP: " + e.Message);
        }

        return ipAddress;
    }

    private string GetCountry(string ipAddress)
    {
        try
        {
            using (WebClient client = new WebClient())
            {
                var code = client.DownloadString($"http://ip-api.com/json/{ipAddress}?fields=countryCode");
                GeoLocationResponse response = JsonUtility.FromJson<GeoLocationResponse>(code);
                string countryCode = response.countryCode;
                 
                return countryCode;
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError("Error while get info: " + e.Message);
            return "Unknown";
        }
    }
     
}

[System.Serializable]
public class GeoLocationResponse
{
    public string countryCode;
}