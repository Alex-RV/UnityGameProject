using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCreator : MonoBehaviour
{
    public Transform Base;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        // for (int i = 0; i < transform.childCount; i++)
        // {
        //     var child = transform.GetChild(i);
        //     var coin = GameObject.Instantiate(SourceObject);
        //     child.position = child.position;
        // }
        // Debug.Log("Coin");
        var Obj = GameObject.Instantiate(Base);
        Obj.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z +5f);
    }
}
