using UnityEngine;
using System.Collections;

public class ShowInterstitialScript : MonoBehaviour
{

    public void OnClick()
    {
        Interop.ShowInterstitialAd();
    }
}
