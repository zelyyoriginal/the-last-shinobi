using System;
using System.Threading.Tasks;
using UnityEngine;
using Zenject;

public class Enemy :MonoBehaviour, IInteractible
{
    private const string _payAnimationName = "Pay";
    [SerializeField] private Animator _animator;
    private Fight _fight;
    private Mover _mover;
    [SerializeField] public int _PassPrise { get; private set; } = 5;

    [Inject]
    private void Constract(Fight fight, Mover mover)
    {
        _fight = fight;
        _mover = mover;
    }


    public  void Action()
    {
        _mover.MoveState(true);
        _fight.StartFight(this);
    }

    public  void Dead()
    {
      Destroy(transform.parent.gameObject);
    }
    public async void Skiped()
    {
        await Task.Delay(950);
        _animator.SetTrigger(_payAnimationName);
    }
}
