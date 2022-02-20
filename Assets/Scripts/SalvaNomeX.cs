using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.IO;
using System.IO;



public class SalvaNomeX : MonoBehaviour
{
    public GameObject inputNomeTesto;
    public string nomeGiocatore;
    public int punteggioGiocatore;

    public void StoreName()
    {
        nomeGiocatore = inputNomeTesto.GetComponent<Text>().text;
    }

    [System.Serializable]
    class SaveData
    {
        public string playerName;
        public int playerScore;

    }
    public void SaveName()
    {
        SaveData data = new SaveData();
        data.playerName = nomeGiocatore;
        data.playerScore = punteggioGiocatore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

        Debug.Log("Ho Salvato!" + json);
    }

    public void LoadName()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            nomeGiocatore = data.playerName;
            punteggioGiocatore = data.playerScore;

            Debug.Log("Ho Caricato!" + json);
        }
    }
}
