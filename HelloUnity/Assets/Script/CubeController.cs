using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//한글

public class CubeController : MonoBehaviour
{
    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //tnis.transform.position = this.transform.position + new Vector3(0,0,1);
        Debug.Log(this.transform.position);
        this.transform.position = this.transform.position + new Vector3(0,0,0.1f);
    }
}
