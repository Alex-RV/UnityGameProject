using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCreator : MonoBehaviour
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
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Floor");
        var Obj = GameObject.Instantiate(Base);
        Obj.transform.position = new Vector3(transform.position.x, transform.position.y -0.6925f, transform.position.z + 10f);
    }
}
// - 0.6925f