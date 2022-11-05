using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinTracker : MonoBehaviour
{
    public int coins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Coin"){
            coins++;
            Debug.Log(coins);
        }
    }
}
