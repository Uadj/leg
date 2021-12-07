using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    
    public GameObject[] cube = new GameObject[4];
    
    
    // Start is called before the first frame update
    void Start()
    {
        int a = Random.Range(1, 4);
        Destroy(cube[a]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
