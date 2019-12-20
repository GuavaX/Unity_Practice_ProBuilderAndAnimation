using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BornCoin : MonoBehaviour
{
    [Header("水晶幣")]
    public GameObject coin;
       

    public void BurnCoin()
    {
        //aud.PlayOneShot(soundCoinBorn);

        Vector3 pos = new Vector3(0, 0, 0);
        Quaternion rot = new Quaternion(0, Random.Range(0,360), 0, 0);
        Instantiate(coin,pos,rot);
    }
    
}
