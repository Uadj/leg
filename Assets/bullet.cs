using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField]
    private Transform origin;
    [SerializeField]
    private GameObject bul;
    private bool isMoving = false;
    private float firerate = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        firerate-=Time.deltaTime;
        if (!isMoving&&Input.GetMouseButton(0)&&firerate<0)
        {
            var temp = Instantiate(bul, origin.transform.position, origin.transform.rotation);
            firerate = 0.5f;
            Destroy(temp, 1f);
        }
        
    }
}
