using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    private CharacterController myChar;
    public FixedJoystick fixedJoystick;
    public float speed;
    private Animator myanim;
    // Start is called before the first frame update
    void Start()
    {
        myChar = GetComponent<CharacterController>();
        myanim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        TryWalking();
    }
    void TryWalking()
    {
        Vector3 MoveDirection = -fixedJoystick.JoyVec;
        if (MoveDirection.magnitude > 0)
        {
            myanim.SetBool("Move", true);
        }
        else
        {
            myanim.SetBool("Move", false);
        }
        myChar.Move(MoveDirection * Time.deltaTime * speed);
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(MoveDirection), 0.2f);
    }
}
