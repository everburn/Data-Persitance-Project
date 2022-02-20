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

}

  
