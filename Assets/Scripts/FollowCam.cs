using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [SerializeField] GameObject playerToFollow;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = playerToFollow.transform.position + new Vector3(0, 0, -10); 
    }
}
