
using System;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;

public class Wallet : MonoBehaviour
{
    [SerializeField]private int _curentCoins;
    [SerializeField]private int _valute = 10;
    public event Action<string> rec;


    

    public void AddCoins()
    {
        _curentCoins += _valute;
         rec?.Invoke(_curentCoins.ToString());
    }


    public bool RemoveCoins(int value)
    {
        if (_curentCoins - value >= 0)
        {
            _curentCoins -= value;
            rec?.Invoke(_curentCoins.ToString());
     
            return true;
            
        }
        else return false;
        
    }
}
