using UnityEngine;
using Zenject;

public class CoinsPresenter : MonoBehaviour
{
    [Inject] private CoinsModel _coinsModel;
    
    public void Awake()
    {
        _coinsModel.OnCoinsUpdate += SaveCoins;
    }

    private void SaveCoins(int amount)
    {
        PlayerPrefs.SetInt("Coins", amount);
    }
    
}