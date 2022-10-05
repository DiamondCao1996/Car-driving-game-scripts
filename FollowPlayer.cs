using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEditor;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;

    public Vector3 offset = new Vector3(0, 5, -7);
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //To ensure the camera is behind the vehicle.
        transform.position = Player.transform.position + offset;

    }
}
