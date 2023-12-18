
using UnityEngine;
using Zenject;

public class EntryPoint : MonoInstaller
{
   [SerializeField]private GameObject _player;
   [SerializeField]private Transform _startPosition,_finishPosition;
  


    public override void InstallBindings()
    {
        InitiolizePlayer();

        Container.Bind<Fight>().FromComponentInHierarchy().AsSingle();
        Container.Bind<MyPath>().FromInstance(new MyPath(_startPosition.position.z, _finishPosition.position.z)).AsSingle();



    }

    private void InitiolizePlayer()
    {
        _player = Container.InstantiatePrefab(_player, _startPosition.position, Quaternion.identity, null);
        Container.Bind<Mover>().FromComponentOn(_player).AsSingle();
        Container.Bind<Wallet>().FromComponentOn(_player).AsSingle();
        Container.Bind<Animator>().FromComponentOn(_player).AsSingle();
    }




}

public class MyPath
{
   public float start { get; private set; }
   public float fight { get; private set; }

   public MyPath(float start, float fight)
    {
        this.start = start;
        this.fight = fight;
    }

    public float GetDistans()
    {
        return (fight - start);
    }
}

