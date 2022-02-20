using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.IO;
using System.IO;

public class PlayerManager : MonoBehaviour
{
    public PlayerManager Instance;
    public GameObject inputNomeGiocatore;
    public string nomeGiocatore;
    public int punteggioGiocatore;

    private void Awake()
    {
        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    //public void StoreName()
    //{
    //    nomeGiocatore = inputNomeGiocatore.GetComponent<Text>().text;
    //    Debug.Log(nomeGiocatore + "Ho Preso il nome!");
    //}

}
