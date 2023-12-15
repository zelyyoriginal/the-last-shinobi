using UnityEngine;

public class Enemy : IneractibleObject
{
    [SerializeField] Fight _fight;
    [SerializeField] public int _PassPrise { get; private set; } = 5;

    public override void Action(GameObject activator)
    {
        Mover player = activator.GetComponent<Mover>();
        player.MetTheEnemy();
        Wallet wallet = activator.GetComponent<Wallet>();

        //идея токава вместо обычной активации кнопок
        //сделать класс и передавать туда Enemy,
        //возможно цену откупа
        //возможно hp enemy

        _fight.StartFight(this,wallet,player);
    }
}
