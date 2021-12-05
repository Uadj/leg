using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterContoller : MonoBehaviour
{
    public GameObject player;
    public Animator anim;
    bool isattack = false;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        lookatplayer();
        attackplayer();
        StartCoroutine("Patrol");

    }
    void lookatplayer()
    {

        transform.LookAt(player.transform.position);
    }
    void attackplayer()
    {
       
        if (Vector3.Distance(transform.position, player.transform.position)<2f)
        {
            isattack = true;
            anim.SetTrigger("Attack");
            isattack = false;
        }
        
    }

    IEnumerator Patrol()
    {
        if (!isattack)
        {
            Vector3 target = new Vector3(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)) + transform.position;
            anim.SetBool("Walking",true);
            yield return new WaitForSeconds(2f);
        }
    }
}
