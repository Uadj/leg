using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterContoller : MonoBehaviour
{
    public GameObject player;
    private Animator anim;
    public float walkspeed;
    Rigidbody rigid;
    bool isattack = false;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
    }
    void Update()
    {
        lookatplayer();
        attackplayer();
        Run();

    }
    void lookatplayer()
    {

        transform.LookAt(player.transform.position);
    }
    void attackplayer()
    {
       
        if (Vector3.Distance(transform.position, player.transform.position)<2f)
        {
            anim.SetBool("Walking", false);
            isattack = true;
            anim.SetTrigger("Attack");
            isattack = false;
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
    void Run()
    {
        if (!isattack)
        {
            Vector3 _velocity = transform.forward*walkspeed;
            rigid.MovePosition(transform.position + _velocity * Time.deltaTime);
            anim.SetBool("Walking",true);
        }
    }
}
