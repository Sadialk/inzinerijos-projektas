using UnityEngine;
using TMPro;
public class Currency : MonoBehaviour
{
    public static Currency money;
    public int startingCurrency = 500;
    private int currentCurrency;
    public TMP_Text currencyText;
    private void Awake()
    {
        money = this;
        Debug.Log("set currency instance");
    }
    void Start()
    {
        currentCurrency = startingCurrency;
        UpdateCurrencyText();
    }

    void UpdateCurrencyText()
    {
        currencyText.text = currentCurrency.ToString();
    }
    public void AddCurrency(int amount)
    {
        currentCurrency += amount;
        UpdateCurrencyText();
    }

    public void RemoveCurrency(int amount)
    {
        currentCurrency -= amount;
        UpdateCurrencyText();
    }

    public int GetCurrentCurrency()
    {
        return currentCurrency;
    }
}