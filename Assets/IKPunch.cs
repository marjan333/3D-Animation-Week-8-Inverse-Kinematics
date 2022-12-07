using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKPunch : MonoBehaviour
{
    Animator anim;
    public GameObject target;
    public float IK_weight = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        anim.SetIKPosition(AvatarIKGoal.LeftHand, target.transform.position);
        anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, IK_weight);
        anim.SetLookAtPosition(target.transform.position);
        anim.SetLookAtWeight(IK_weight);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            anim.SetTrigger("punch");
    }
}
