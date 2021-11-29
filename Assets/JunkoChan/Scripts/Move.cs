using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 dir;
    private CharacterController charc;
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        charc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        dir = new Vector3(x, 0, z).normalized ;
        transform.position += dir * Time.deltaTime *speed;
        transform.LookAt(transform);
    }
}
