using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform playertransform;
    public bool tp;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        tp = true;
        if(other.tag == "Player")
        {
            playertransform.transform.position += new Vector3(0, 10, 0);
            Debug.Log(tp);
        }
        tp = false;
    }
}
