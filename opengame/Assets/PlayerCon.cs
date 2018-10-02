using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    private Rigidbody rigid;
    Vector3 Normal_g;
    [SerializeField]
    private float speed;
    RaycastHit hit;
    // Use this for initialization
    void Start()
    {
        rigid = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frameds

    private void FixedUpdate()
    {


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        rigid.velocity=(-transform.forward*z+transform.right*x);
        if (Physics.Raycast(transform.position, -transform.up, out hit, float.PositiveInfinity))//球体に添わせるために開店をする
        {
            Quaternion q = Quaternion.FromToRotation(transform.up, hit.normal);
            transform.rotation *= q;
        }
    }
  
}
