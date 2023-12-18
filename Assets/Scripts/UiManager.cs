using TMPro;
using UnityEngine;
using Zenject;

namespace Assets.Scripts
{
    public class UiManager : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _coins;

        [Inject]
        private void Constract(Wallet wallet)
        {
            wallet.rec += ReDraw;
        }


        private void  ReDraw(string value)
        {
            _coins.text = value;
        }

       

    }
}