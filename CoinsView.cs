using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class CoinsView
{
    [SerializeField] private Text _render;
    [SerializeField] private Animator _animator;
    
    [Inject] private CoinsModel _coinsModel;

    public void Awake()
    {
        _coinsModel.OnCoinsUpdate += AnimateCoins;
    }
    
    public void AnimateCoins(int amount)
    {
        _render.text = $"Coins: {amount}";
        _animator.SetTrigger("OnPickupCoin");
    }
}
