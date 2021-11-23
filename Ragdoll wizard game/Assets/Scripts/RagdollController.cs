using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour
{
    public GameObject[] physicsRig, animationRig;
    public float limbRotationSpeed, limbMovementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < physicsRig.Length; i++)
        {
            RagdollLimb rl = physicsRig[i].AddComponent<RagdollLimb>();
            rl.target = animationRig[i].transform;
            rl.rotateSpeed = limbRotationSpeed;
            rl.speed = limbMovementSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
