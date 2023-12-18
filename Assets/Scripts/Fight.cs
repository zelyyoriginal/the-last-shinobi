using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

public class Fight : MonoBehaviour
{
    private const string _atackAnimationName = "Atack";
    private const string _payAnimationName = "Pay";
    private Enemy _curentEnemy;
    private Wallet _wallet;
    private Mover _mover;
    private Animator _animatorPlayer;
    private List<GameObject> _buttons = new List<GameObject>();


    [Inject]
    private void Construct(Wallet W , Mover M, Animator animator)
    {
        _wallet = W;
        _mover = M;
        _animatorPlayer = animator;
        
    }

    private void Start()
    {
       foreach(Transform cild in transform)
        {
            _buttons.Add(cild.gameObject);
        }
       
    }

    public void StartFight(Enemy enemy)
    {
        _curentEnemy = enemy;
        ButtonsVision(true);

    }


    public async void Attack()
    {
        ButtonsVision(false);
        _animatorPlayer.SetTrigger(_atackAnimationName);
        await Task.Delay(500);
        _curentEnemy.Dead();
        _mover.MoveState(false);

    }
    public async void PayOf() 
    {
     
        
       if(_wallet.RemoveCoins(_curentEnemy._PassPrise))
        {
           
            ButtonsVision(false);
            _animatorPlayer.SetTrigger(_payAnimationName);
            _curentEnemy.Skiped();
            await Task.Delay(1000);
            _mover.MoveState(false);
          
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
