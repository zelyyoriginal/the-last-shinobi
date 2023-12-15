using UnityEngine;
public class Coin : IneractibleObject
{
    public override void Action(GameObject activator)
    {
        activator.GetComponent<Wallet>().AddCoins();
        Destroy(gameObject);
    }
}
