using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;
using RandomNameAndCountry.Scripts;
using UnityEngine.UIElements;

public class BotTextFirstTime : MonoBehaviour
{
    public PlayerDataUIValue PlayerDataUIValue;
    public bool FirstTime;
    public GameObject text3DBot;
    public TMP_Text text3DBotText;
    public RandomPlayerInfo m_playerInfo = new RandomPlayerInfo();
    Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main; 
        PlayerDataUIValue = FindObjectOfType<PlayerDataUIValue>();
        if(PlayerDataUIValue != null )
        {
            FirstTime = Geekplay.Instance.PlayerData.PlayerFirstTimePlay;
        }
        else
        {
            FirstTime = false;
        }
        text3DBot.gameObject.SetActive(true);

        
        m_playerInfo = RandomNameAndCountryPicker.Instance.GetRandomPlayerInfo();

        if (FirstTime == true)
        {
            
        }
        else
        {
            int i = Random.Range(0, 100);
            if (i > 10)
            {
                text3DBotText.text = m_playerInfo.playerName;
            }
            else
            {
                text3DBotText.text = "Bot";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        text3DBot.transform.LookAt(cam.transform);
        text3DBot.transform.eulerAngles = new Vector3(0, text3DBot.transform.eulerAngles.y, 0);

    }
}
