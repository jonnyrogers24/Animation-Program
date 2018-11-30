using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
using TMPro; 

public class ShopController : MonoBehaviour
{
    private int moneyAmount;
    private int isWaterCraftSold; 
    
    public TextMeshProUGUI moneyAmountText;
    public TextMeshProUGUI craftPrice;

    public Button purchaseButton;

    private void Start()
    {
        moneyAmount = PlayerPrefs.GetInt("MoneyAmount");
        
    }

    private void Update()
    {
        moneyAmountText.text = "Bubbles: " + moneyAmount.ToString();

        isWaterCraftSold = PlayerPrefs.GetInt("IsWaterCraftSold");
        if (moneyAmount >= 50 && isWaterCraftSold == 0)
            purchaseButton.interactable = true;
        else
            purchaseButton.interactable = false; 
    }

    public void BuyWaterCraft()
    {
        moneyAmount -= 50;
        PlayerPrefs.SetInt("IsWaterCraftSold", 1);
        craftPrice.text = "Sold!";
       purchaseButton.gameObject.SetActive(false);
    }

    public void ExitShop()
    {
        PlayerPrefs.SetInt("MoneyAmount", moneyAmount);
    }

    public void resetPlayerPrefs()
    {
        moneyAmount = 0;
        purchaseButton.gameObject.SetActive(true);
        craftPrice.text = "Cost : 50 Bubbles";
        PlayerPrefs.DeleteAll ();

    }
}
