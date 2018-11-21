
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class TCIFlogoDeviceStatusUpdate : MonoBehaviour {
    
    private string Hostname = "https://eu-west-1.integration.cloud.tibcoapps.com:443";
    
    [Header("TIBCO Cloud Integration Service Settings")]
    public string Servicekey = "<your Service Key>";
    public string ServiceEndpoint = "devicestatus";

    [Space]
    [Header("Datafields")]
    public Text deviceName;
    public Text deviceStatus;

    public void DeviceStatusRefresh() {
        Debug.Log("Device Status refresh");
        //allows modelling behaviour over several Unity frames 
        StartCoroutine(GetDeviceStatus(Hostname + "/" + Servicekey + "/" + ServiceEndpoint + "/" + deviceName.text));
    }

	// REST GET Sample, ... will add more later.
    IEnumerator GetDeviceStatus(string url)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(url);
        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError)
        {
            Debug.Log("Error While Sending the Request: " + uwr.error);
        }
        else
        {
            Debug.Log("Received full Dataset: " + uwr.downloadHandler.text);

            //used JSON Object phraser from here:
            // Asset Store: https://assetstore.unity.com/packages/tools/input-management/json-object-710
            // Git Hub: https://github.com/mtschoen/JSONObject
            JSONObject j = new JSONObject(uwr.downloadHandler.text);
            JSONObject status = j["status"];
            deviceStatus.text = status.str;
        }
    }

}
