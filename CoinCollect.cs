using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other){
        // Debug.Log("Coin");
        GameObject.Destroy(gameObject);
        
    }
    private void FixedUpdate(){
        transform.Rotate(Vector3.left);
    }
    // private void FixedUpdate(){
    //     transform.rotation = Quaternion.EulerRotation(transform.rotation.x, 
    //     transform.rotation.y + 1.0f, transform.rotation.z);
    // }
}
