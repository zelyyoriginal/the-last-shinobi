using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    private Enemy _curentEnemy;
    private Wallet _wallet;
    private Mover _mover;
  [SerializeField]  private List< GameObject> _buttons= new List<GameObject>();

    private void Start()
    {
       foreach(Transform cild in transform)
        {
            _buttons.Add(cild.gameObject);
        }
       
    }

    public void StartFight(Enemy enemy, Wallet wallet,Mover mover)
    {
        _curentEnemy = enemy;
        this._wallet = wallet;
        this._mover = mover;
        ButtonsVision(true);

    }


    public void Attack()
    {
        Destroy(_curentEnemy.gameObject);
        _mover.keepGoing();
        ButtonsVision(false);

    }
    public void PayOf() 
    {
     
        
       if(_wallet.RemoveCoins(_curentEnemy._PassPrise))
        {
            //оплачено
            _mover.keepGoing();
            ButtonsVision(false);
            //убрать окошко разрешить двигатся
        }
        else
        {
            Debug.Log("денег нет но вы держитесь");
        }


    }


    private void ButtonsVision(bool isactiv)
    {

        foreach(GameObject button in _buttons)
        {
            button.SetActive(isactiv);
        }
    }
}
