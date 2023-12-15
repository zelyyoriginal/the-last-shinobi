
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Wallet : MonoBehaviour
{
    [SerializeField]private int _curentCoins;
    [SerializeField]private int _valute= 10;

    public UnityEvent<string> Recount;
  


    public void AddCoins()
    {
        _curentCoins += _valute;
        Recount?.Invoke(_curentCoins.ToString());
    }


    public bool RemoveCoins(int value)//залепа
    {
        if (_curentCoins - value > 0)
        {
            _curentCoins -= value;
            Recount?.Invoke(_curentCoins.ToString());
            return true;
            
        }
        else return false;
        
    }
}
