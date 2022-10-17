using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    //public static int brujitaLife;
    //public static bool alive=true;

    public Image[] corazones;
    public static int livesLimit;

    // Start is called before the first frame update
    void Start()
    {
        livesLimit = 6;
        corazones[0].gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        SetLivesUI();
    }

    void SetLivesUI()
    {
        for(int i = 0; i < Thea.lives; i++)
        {
            corazones[i].gameObject.SetActive(true);
        }
        for(int i = Thea.lives; i < corazones.Length; i++)
        {
            corazones[i].gameObject.SetActive(false);
        }
    }
   

    void UpdateUI()
    {

    }
}
