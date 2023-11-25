using System;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    #region variables
    
    private float speed;
    private Vector3 velocity;

    #endregion variables

    #region public functions

    public void MoveTarget(GameObject target, MoveType type = MoveType.None)
    {
        //TypeToMove was typed for other cases
        SetVelocity();
        Move(target);
    }

    #endregion public functions

    #region private functions

    private void Move(GameObject target)
    {
        Rigidbody rb = target.GetComponent<Rigidbody>();
        rb.AddForce(velocity, ForceMode.Force);
    }

    private void SetVelocity()
    {
        GetData();
        velocity = Vector3.forward * Time.deltaTime * speed;
    }

    private void GetData()
    {
        speed = Data.instance.DynamicData.MoveData.Speed;
    }

    private void Start()
    {
        GetData();
    }

    #endregion private functions

}
