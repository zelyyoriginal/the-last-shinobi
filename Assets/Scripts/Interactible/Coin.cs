using UnityEngine;
using Zenject;
public class Coin :MonoBehaviour, IInteractible
{
    private Wallet _wallet;
    [Inject]
    private void Construct(Wallet wallet) {  _wallet = wallet; }


    public void Action()
    {
        _wallet.AddCoins();
        Destroy(gameObject);
    }
}
