using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class PlayerController : MonoBehaviour
{
    public SteamVR_Action_Vector2 input;
    public float _speed = 1;

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
        transform.position += _speed * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up);
    }
}
