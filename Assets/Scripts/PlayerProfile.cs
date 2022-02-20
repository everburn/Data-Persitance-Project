using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerProfile : MonoBehaviour
{

    public static PlayerProfile Instance;
    public Text inputNomeGiocatore ;
    string nomeGiocatore;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        
    }


   // public void nuovoNomeScelto ( Text nomeGiocatore )
   // {
   //     nomeGiocatore = GetComponent<Text>();
   //     PlayerProfile.Instance.inputNomeGiocatore = nomeGiocatore;
   //
   //     return;
  //  }

   // private void Start()
   // {
   //     if (PlayerProfile.Instance != null)
   //     {
   //         SettaNomeGiocatore(PlayerProfile.Instance.settaNomeGiocatore);
   //     }
   // }

   // public void SettaNomeGiocatore ( Text settaNomeGiocatore)
   //  {
  //      PlayerProfile.Instance.profiloGiocatore = settaNomeGiocatore ;
  //  }
}