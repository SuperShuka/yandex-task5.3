using System;
using UnityEngine;

public class CoinsModel
{
    public int Amount;
    
    public Action<int> OnCoinsUpdate;

    public CoinsModel(int amount)
    {
        Amount = amount;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("Coin"))
            OnPickupCoin();
    }
    
    public void OnPickupCoin()
    {
        Amount++;
        OnCoinsUpdate.Invoke(Amount);
    }

    public bool TryDiscard(int price)
    {
        if (Amount < price)
            return false;

        Amount -= price;
        OnCoinsUpdate.Invoke(Amount);

        return true;
    }
}
