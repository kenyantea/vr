using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Text nm;
    public string jsonURL = https://drive.google.com/uc?export=download&id=19rSC6wNyos6CCxeOrpS3ydIOgvqu4J0t;
    public Jsonclass jsnData;
    void Start()
    {
        dat1.interactable = false;
        StartCoroutine(getData());
    }
    IEnumerator getData()
    {
        Debug.Log("Download...");
        var uwr = new UnityWebRequest(jsonURL);
        uwr.method = UnityWebRequest.kHttpVerbGET;
        var resultFile = Path.Combine(Application.persistentDataPath, "result.json");
        var dh = new DownloadHandlerFile(resultFile);
        dh.removeFileOnAbort = true;
        uwr.download Handler = dh;
        yield return uwr.SendWebRequest();
        if (uwr.result != UnityWebRequest.Result.Success)
            nm.text = "ERROR";
        else
        {
            Debug.Log("Download saved to: " + resultFile);
            jsnData = JsonUtility.FromJson<Jsonclass>(File.ReadAllText(Application.persistentDataPath + "\\result.json"));
            //nm.text = jsnData.Name.ToString();
            yield return StartCoroutine(getData());
        }
    }
    [System.Serializable]
    public class Jsonclass
    {
        public int number;
    }
}
