using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BuyButton : MonoBehaviour
{
    public GameObject CheckChar;
    public GameObject CanvasMain;
    public GameObject ThisCharacter;
    public CheckCharactersScript CCharScript;
    public Geekplay CMainInit;
    public bool isBodies;
    public bool isBodyparts;
    public bool isEyes;
    public bool isGloves;
    public bool isHeadparts;
    public bool isMounth;
    public bool isNoise;
    public bool isCombs;
    public bool isEars;
    public bool isEyesFromHead;
    public bool isHair;
    public bool isHat;
    public bool isHorn;
    public bool isTails;

    public int idBuy;
    public int idCost;
    public int idCostHard;
    public bool idIsHardMoney;
    public bool idIsAD;
    public bool isBought;
    public TMP_Text textBuy;

    public AudioSource audioSource;

    public void Start()
    {
        CCharScript = CheckChar.GetComponent<CheckCharactersScript>();
        CMainInit = CanvasMain.GetComponent<Geekplay>();
    }

    public void StartBuy()
    {
        if(isBought == false)
        {
            if (isBodies)
            {
                if (CMainInit.PlayerData.Bodies[idBuy] == 0)
                {
                    if(idIsHardMoney == true && CMainInit.PlayerData.PlayerHardMoney >= idCostHard)
                    {
                        audioSource.clip.name = "Buy";
                        audioSource.Play();
                        CMainInit.PlayerData.PlayerHardMoney -= idCostHard;
                        CMainInit.PlayerData.Bodies[idBuy] = 1;
                        this.gameObject.SetActive(false);
                        Debug.Log("Geekplay.Instance.Save()");
                    }
                    else if(idIsHardMoney == false && CMainInit.PlayerData.PlayerMoney >= idCost)
                    {
                        audioSource.clip.name = "Buy";
                        audioSource.Play();
                        CMainInit.PlayerData.PlayerMoney -= idCost;
                        CMainInit.PlayerData.Bodies[idBuy] = 1;
                        this.gameObject.SetActive(false);
                        Debug.Log("Geekplay.Instance.Save()");
                    }
                    else if(idIsAD)
                    {
                        Geekplay.Instance.ShowRewardedAd("ShopBody");
                    }
                }
                else
                {

                }
            }
            else if (isBodyparts)
            {
                if (CMainInit.PlayerData.Bodyparts[idBuy] == 0)
                {
                    if (idIsHardMoney == true && CMainInit.PlayerData.PlayerHardMoney >= idCostHard)
                    {
                        CMainInit.PlayerData.PlayerHardMoney -= idCostHard;
                        CMainInit.PlayerData.Bodyparts[idBuy] = 1;
                        this.gameObject.SetActive(false);
                        Debug.Log("Geekplay.Instance.Save()");
                    }
                    else if (idIsHardMoney == false && CMainInit.PlayerData.PlayerMoney >= idCost)
                    {
                        CMainInit.PlayerData.PlayerMoney -= idCost;
                        CMainInit.PlayerData.Bodyparts[idBuy] = 1;
                        this.gameObject.SetActive(false);
                        Debug.Log("Geekplay.Instance.Save()");
                    }
                    else if (idIsAD)
                    {
                        Geekplay.Instance.ShowRewardedAd("ShopBodyparts");
                    }
                }
                else
                {
                    
                    
                }
            }
            else if (isEyes)
            {
                if (CMainInit.PlayerData.Eyes[idBuy] == 0)
                {
                    if (idIsHardMoney == true && CMainInit.PlayerData.PlayerHardMoney >= idCostHard)
                    {
                        CMainInit.PlayerData.PlayerHardMoney -= idCostHard;
                        CMainInit.PlayerData.Eyes[idBuy] = 1;
                        this.gameObject.SetActive(false);
                        Debug.Log("Geekplay.Instance.Save()");
                    }
                    else if (idIsHardMoney == false && CMainInit.PlayerData.PlayerMoney >= idCost)
                    {
                        CMainInit.PlayerData.PlayerMoney -= idCost;
                        CMainInit.PlayerData.Eyes[idBuy] = 1;
                        this.gameObject.SetActive(false);
                        Debug.Log("Geekplay.Instance.Save()");
                    }
                    else if (idIsAD)
                    {
                        Geekplay.Instance.ShowRewardedAd("ShopEyes");
                    }
                }
                else
                {
                     
                }
            }
            else if (isGloves)
            {
                if (CMainInit.PlayerData.Gloves[idBuy] == 0)
                {
                    if (idIsHardMoney == true && CMainInit.PlayerData.PlayerHardMoney >= idCostHard)
                    {
                        CMainInit.PlayerData.PlayerHardMoney -= idCostHard;
                        CMainInit.PlayerData.Gloves[idBuy] = 1;
                        this.gameObject.SetActive(false);
                        Debug.Log("Geekplay.Instance.Save()");
                    }
                    else if (idIsHardMoney == false && CMainInit.PlayerData.PlayerMoney >= idCost)
                    {
                        CMainInit.PlayerData.PlayerMoney -= idCost;
                        CMainInit.PlayerData.Gloves[idBuy] = 1;
                        this.gameObject.SetActive(false);
                        Debug.Log("Geekplay.Instance.Save()");
                    }
                    else if (idIsAD)
                    {
                        Geekplay.Instance.ShowRewardedAd("ShopGloves");
                    }
                }
                else
                {
                    
                }
            }
            else if (isHeadparts)
            {
                if (idIsHardMoney == true && CMainInit.PlayerData.PlayerHardMoney >= idCostHard)
                {
                    CMainInit.PlayerData.PlayerHardMoney -= idCostHard;
                    CMainInit.PlayerData.Headparts[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsHardMoney == false && CMainInit.PlayerData.PlayerMoney >= idCost)
                {
                    CMainInit.PlayerData.PlayerMoney -= idCost;
                    CMainInit.PlayerData.Headparts[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsAD)
                {
                    Geekplay.Instance.ShowRewardedAd("ShopHeadparts");
                }
            }
            else if (isMounth)
            {
                if (idIsHardMoney == true && CMainInit.PlayerData.PlayerHardMoney >= idCostHard)
                {
                    CMainInit.PlayerData.PlayerHardMoney -= idCostHard;
                    CMainInit.PlayerData.Mounth[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsHardMoney == false && CMainInit.PlayerData.PlayerMoney >= idCost)
                {
                    CMainInit.PlayerData.PlayerMoney -= idCost;
                    CMainInit.PlayerData.Mounth[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsAD)
                {
                    Geekplay.Instance.ShowRewardedAd("ShopMouth");
                }
            }
            else if (isNoise)
            {
                if (idIsHardMoney == true && CMainInit.PlayerData.PlayerHardMoney >= idCostHard)
                {
                    CMainInit.PlayerData.PlayerHardMoney -= idCostHard;
                    CMainInit.PlayerData.Noise[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsHardMoney == false && CMainInit.PlayerData.PlayerMoney >= idCost)
                {
                    CMainInit.PlayerData.PlayerMoney -= idCost;
                    CMainInit.PlayerData.Noise[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsAD)
                {
                    Geekplay.Instance.ShowRewardedAd("ShopNoise");
                }
            }
            else if (isCombs)
            {
                if (idIsHardMoney == true && CMainInit.PlayerData.PlayerHardMoney >= idCostHard)
                {
                    CMainInit.PlayerData.PlayerHardMoney -= idCostHard;
                    CMainInit.PlayerData.Combs[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsHardMoney == false && CMainInit.PlayerData.PlayerMoney >= idCost)
                {
                    CMainInit.PlayerData.PlayerMoney -= idCost;
                    CMainInit.PlayerData.Combs[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsAD)
                {
                    Geekplay.Instance.ShowRewardedAd("ShopCombs");
                }
            }
            else if (isEars)
            {
                if (idIsHardMoney == true && CMainInit.PlayerData.PlayerHardMoney >= idCostHard)
                {
                    CMainInit.PlayerData.PlayerHardMoney -= idCostHard;
                    CMainInit.PlayerData.Ears[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsHardMoney == false && CMainInit.PlayerData.PlayerMoney >= idCost)
                {
                    CMainInit.PlayerData.PlayerMoney -= idCost;
                    CMainInit.PlayerData.Ears[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsAD)
                {
                    Geekplay.Instance.ShowRewardedAd("ShopEars");
                }
            }
            else if (isEyesFromHead)
            {
                if (idIsHardMoney == true && CMainInit.PlayerData.PlayerHardMoney >= idCostHard)
                {
                    CMainInit.PlayerData.PlayerHardMoney -= idCostHard;
                    CMainInit.PlayerData.EyesFromHead[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsHardMoney == false && CMainInit.PlayerData.PlayerMoney >= idCost)
                {
                    CMainInit.PlayerData.PlayerMoney -= idCost;
                    CMainInit.PlayerData.EyesFromHead[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsAD)
                {
                    Geekplay.Instance.ShowRewardedAd("ShopEyesFromHead");
                }
            }
            else if (isHair)
            {
                if (idIsHardMoney == true && CMainInit.PlayerData.PlayerHardMoney >= idCostHard)
                {
                    CMainInit.PlayerData.PlayerHardMoney -= idCostHard;
                    CMainInit.PlayerData.Hair[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsHardMoney == false && CMainInit.PlayerData.PlayerMoney >= idCost)
                {
                    CMainInit.PlayerData.PlayerMoney -= idCost;
                    CMainInit.PlayerData.Hair[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsAD)
                {
                    Geekplay.Instance.ShowRewardedAd("ShopHair");
                }
            }
            else if (isHat)
            {
                if (idIsHardMoney == true && CMainInit.PlayerData.PlayerHardMoney >= idCostHard)
                {
                    CMainInit.PlayerData.PlayerHardMoney -= idCostHard;
                    CMainInit.PlayerData.Hat[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsHardMoney == false && CMainInit.PlayerData.PlayerMoney >= idCost)
                {
                    CMainInit.PlayerData.PlayerMoney -= idCost;
                    CMainInit.PlayerData.Hat[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsAD)
                {
                    Geekplay.Instance.ShowRewardedAd("ShopHat");
                }
            }
            else if (isHorn)
            {
                if (idIsHardMoney == true && CMainInit.PlayerData.PlayerHardMoney >= idCostHard)
                {
                    CMainInit.PlayerData.PlayerHardMoney -= idCostHard;
                    CMainInit.PlayerData.Horn[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsHardMoney == false && CMainInit.PlayerData.PlayerMoney >= idCost)
                {
                    CMainInit.PlayerData.PlayerMoney -= idCost;
                    CMainInit.PlayerData.Horn[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsAD)
                {
                    Geekplay.Instance.ShowRewardedAd("ShopHorn");
                }
            }
            else if (isTails)
            {
                if (idIsHardMoney == true && CMainInit.PlayerData.PlayerHardMoney >= idCostHard)
                {
                    CMainInit.PlayerData.PlayerHardMoney -= idCostHard;
                    CMainInit.PlayerData.Tails[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsHardMoney == false && CMainInit.PlayerData.PlayerMoney >= idCost)
                {
                    CMainInit.PlayerData.PlayerMoney -= idCost;
                    CMainInit.PlayerData.Tails[idBuy] = 1;
                    this.gameObject.SetActive(false);
                    Debug.Log("Geekplay.Instance.Save()");
                }
                else if (idIsAD)
                {
                    Geekplay.Instance.ShowRewardedAd("ShopTail");
                }
            }
            else
            {
                
            }
        }
        else
        {
            if (isBodies)
            {
                if (CMainInit.PlayerData.Bodies[idBuy] > 0)
                {
                     
                    if (CMainInit.PlayerData.CharacterBodies[idBuy] == 0)
                    {
                        CMainInit.PlayerData.CharacterBodies[idBuy] = 1;
                    }
                    else
                    {
                        CMainInit.PlayerData.CharacterBodies[idBuy] = 0;
                    }
                }
                else
                {
                     
                }
            }
            else if (isBodyparts)
            {
                if (CMainInit.PlayerData.Bodyparts[idBuy] > 0)
                {
                     
                    if(CMainInit.PlayerData.CharacterBodyparts[idBuy] == 0)
                    {
                        CMainInit.PlayerData.CharacterBodyparts[idBuy] = 1;
                    }
                    else
                    {
                        CMainInit.PlayerData.CharacterBodyparts[idBuy] = 0;
                    }
                }
                else
                {
                     
                }
            }
            else if (isEyes)
            {
                if (CMainInit.PlayerData.Eyes[idBuy] > 0)
                {
                     
                    if (CMainInit.PlayerData.CharacterEyes[idBuy] == 0)
                    {
                        CMainInit.PlayerData.CharacterEyes[idBuy] = 1;
                    }
                    else
                    {
                        CMainInit.PlayerData.CharacterEyes[idBuy] = 0;
                    }
                }
                else
                {
                     
                }
            }
            else if (isGloves)
            {
                if (CMainInit.PlayerData.Gloves[idBuy] > 0)
                {
                     
                    if (CMainInit.PlayerData.CharacterGloves[idBuy] == 0)
                    {
                        CMainInit.PlayerData.CharacterGloves[idBuy] = 1;
                    }
                    else
                    {
                        CMainInit.PlayerData.CharacterGloves[idBuy] = 0;
                    }
                }
                else
                {
                     
                }
            }
            else if (isHeadparts)
            {
                if (CMainInit.PlayerData.Headparts[idBuy] > 0)
                {
                     
                    if (CMainInit.PlayerData.CharacterHeadparts[idBuy] == 0)
                    {
                        CMainInit.PlayerData.CharacterHeadparts[idBuy] = 1;
                    }
                    else
                    {
                        CMainInit.PlayerData.CharacterHeadparts[idBuy] = 0;
                    }
                }
                else
                {
                     
                }
            }
            else if (isMounth)
            {
                if (CMainInit.PlayerData.Mounth[idBuy] > 0)
                {
                     
                    if (CMainInit.PlayerData.CharacterMounth[idBuy] == 0)
                    {
                        CMainInit.PlayerData.CharacterMounth[idBuy] = 1;
                    }
                    else
                    {
                        CMainInit.PlayerData.CharacterMounth[idBuy] = 0;
                    }
                }
                else
                {
                     
                }
            }
            else if (isNoise)
            {
                if (CMainInit.PlayerData.Noise[idBuy] > 0)
                {
                     
                    if (CMainInit.PlayerData.CharacterNoise[idBuy] == 0)
                    {
                        CMainInit.PlayerData.CharacterNoise[idBuy] = 1;
                    }
                    else
                    {
                        CMainInit.PlayerData.CharacterNoise[idBuy] = 0;
                    }
                }
                else
                {
                     
                }
            }
            else if (isCombs)
            {
                if (CMainInit.PlayerData.Combs[idBuy] > 0)
                {
                     
                    if (CMainInit.PlayerData.CharacterCombs[idBuy] == 0)
                    {
                        CMainInit.PlayerData.CharacterCombs[idBuy] = 1;
                    }
                    else
                    {
                        CMainInit.PlayerData.CharacterCombs[idBuy] = 0;
                    }
                }
                else
                {
                     
                }
            }
            else if (isEars)
            {
                if (CMainInit.PlayerData.Ears[idBuy] > 0)
                {
                     
                    if (CMainInit.PlayerData.CharacterEars[idBuy] == 0)
                    {
                        CMainInit.PlayerData.CharacterEars[idBuy] = 1;
                    }
                    else
                    {
                        CMainInit.PlayerData.CharacterEars[idBuy] = 0;
                    }
                }
                else
                {
                     
                }
            }
            else if (isEyesFromHead)
            {
                if (CMainInit.PlayerData.EyesFromHead[idBuy] > 0)
                {
                     
                    if (CMainInit.PlayerData.CharacterEyesFromHead[idBuy] == 0)
                    {
                        CMainInit.PlayerData.CharacterEyesFromHead[idBuy] = 1;
                    }
                    else
                    {
                        CMainInit.PlayerData.CharacterEyesFromHead[idBuy] = 0;
                    }
                }
                else
                {
                     
                }
            }
            else if (isHair)
            {
                if (CMainInit.PlayerData.Hair[idBuy] > 0)
                {
                     
                    if (CMainInit.PlayerData.CharacterHair[idBuy] == 0)
                    {
                        CMainInit.PlayerData.CharacterHair[idBuy] = 1;
                    }
                    else
                    {
                        CMainInit.PlayerData.CharacterHair[idBuy] = 0;
                    }
                }
                else
                {
                     
                }
            }
            else if (isHat)
            {
                if (CMainInit.PlayerData.Hat[idBuy] > 0)
                {
                     
                    if (CMainInit.PlayerData.CharacterHat[idBuy] == 0)
                    {
                        CMainInit.PlayerData.CharacterHat[idBuy] = 1;
                    }
                    else
                    {
                        CMainInit.PlayerData.CharacterHat[idBuy] = 0;
                    }
                }
                else
                {
                     
                }
            }
            else if (isHorn)
            {
                if (CMainInit.PlayerData.Horn[idBuy] > 0)
                {
                     
                    if (CMainInit.PlayerData.CharacterHorn[idBuy] == 0)
                    {
                        CMainInit.PlayerData.CharacterHorn[idBuy] = 1;
                    }
                    else
                    {
                        CMainInit.PlayerData.CharacterHorn[idBuy] = 0;
                    }
                }
                else
                {
                     
                }
            }
            else if (isTails)
            {
                if (CMainInit.PlayerData.Tails[idBuy] > 0)
                {
                     
                    if (CMainInit.PlayerData.CharacterTails[idBuy] == 0)
                    {
                        CMainInit.PlayerData.CharacterTails[idBuy] = 1;
                    }
                    else
                    {
                        CMainInit.PlayerData.CharacterTails[idBuy] = 0;
                    }
                }
                else
                {
                     
                }
            }
        }
        
        /*else if (is)
        {
            if (CMainInit.PlayerData.[idBuy] == 0)
            {
                CMainInit.PlayerData.[idBuy] = 1;
            }
        }*/

    }

    public void OnEnable()
    {
        CanvasMain = FindObjectOfType<Geekplay>().gameObject;
        CMainInit = CanvasMain.GetComponent<Geekplay>();
    }

    public void OnDisable()
    {
        
    }
    private void Update()
    {
        if(isBought == false)
        {
            textBuy.text = "Buy";
        }
        else
        {
            textBuy.text = "Equip";
        }
    }

    public void AdBuyBodies()
    {
        CMainInit.PlayerData.Bodies[idBuy] = 1;
        audioSource.clip.name = "Buy";
        audioSource.Play();
        Debug.Log("Geekplay.Instance.Save()");
    }
    public void AdBuyBodyparts()
    {
        CMainInit.PlayerData.Bodyparts[idBuy] = 1;
        audioSource.clip.name = "Buy";
        audioSource.Play();
        Debug.Log("Geekplay.Instance.Save()");
    }
    public void AdBuyEyes()
    {
        CMainInit.PlayerData.Eyes[idBuy] = 1;
        audioSource.clip.name = "Buy";
        audioSource.Play();
        Debug.Log("Geekplay.Instance.Save()");
    }
    public void AdBuyGloves()
    {
        CMainInit.PlayerData.Gloves[idBuy] = 1;
        audioSource.clip.name = "Buy";
        audioSource.Play();
        Debug.Log("Geekplay.Instance.Save()");
    }
    public void AdBuyHeadparts()
    {
        CMainInit.PlayerData.Headparts[idBuy] = 1;
        audioSource.clip.name = "Buy";
        audioSource.Play();
        Debug.Log("Geekplay.Instance.Save()");
    }
    public void AdBuyMounth()
    {
        CMainInit.PlayerData.Mounth[idBuy] = 1;
        audioSource.clip.name = "Buy";
        audioSource.Play();
        Debug.Log("Geekplay.Instance.Save()");
    }
    public void AdBuyNoise()
    {
        CMainInit.PlayerData.Noise[idBuy] = 1;
        audioSource.clip.name = "Buy";
        audioSource.Play();
        Debug.Log("Geekplay.Instance.Save()");
    }
    public void AdBuyCombs()
    {
        CMainInit.PlayerData.Combs[idBuy] = 1;
        audioSource.clip.name = "Buy";
        audioSource.Play();
        Debug.Log("Geekplay.Instance.Save()");
    }
    public void AdBuyEars()
    {
        CMainInit.PlayerData.Ears[idBuy] = 1;
        audioSource.clip.name = "Buy";
        audioSource.Play();
        Debug.Log("Geekplay.Instance.Save()");
    }
    public void AdBuyEyesFromHead()
    {
        CMainInit.PlayerData.EyesFromHead[idBuy] = 1;
        audioSource.clip.name = "Buy";
        audioSource.Play();
        Debug.Log("Geekplay.Instance.Save()");
    }
    public void AdBuyHair()
    {
        CMainInit.PlayerData.Hair[idBuy] = 1;
        audioSource.clip.name = "Buy";
        audioSource.Play();
        Debug.Log("Geekplay.Instance.Save()");
    }
    public void AdBuyHat()
    {
        CMainInit.PlayerData.Hat[idBuy] = 1;
        audioSource.clip.name = "Buy";
        audioSource.Play();
        Debug.Log("Geekplay.Instance.Save()");
    }
    public void AdBuyHorn()
    {
        CMainInit.PlayerData.Horn[idBuy] = 1;
        audioSource.clip.name = "Buy";
        audioSource.Play();
        Debug.Log("Geekplay.Instance.Save()");
    }
    public void AdBuyTail()
    {
        CMainInit.PlayerData.Tails[idBuy] = 1;
        audioSource.clip.name = "Buy";
        audioSource.Play();
        Debug.Log("Geekplay.Instance.Save()");
    }
}
