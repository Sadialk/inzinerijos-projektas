using UnityEngine;

public class PlayerCurrency : MonoBehaviour
{
    public int startingCurrency = 500;
    private int currentCurrency;

    void Start()
    {
        currentCurrency = startingCurrency;
    }

    public void AddCurrency(int amount)
    {
        currentCurrency += amount;
    }

    public void RemoveCurrency(int amount)
    {
        currentCurrency -= amount;
    }

    public int GetCurrentCurrency()
    {
        return currentCurrency;
    }
}