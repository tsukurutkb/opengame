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

        WalkonSphere();
    }

    void WalkonSphere(){
        Vector3 vec_normal=transform.position;
        vec_normal.Normalize();
        Vector3 forward_vec=transform.forward;
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        rigid.velocity=(transform.forward*z);
        transform.Rotate(transform.up,x,Space.World);
        Vector3 projected_vec=Vector3.ProjectOnPlane(transform.forward,vec_normal);
        transform.rotation=Quaternion.LookRotation(projected_vec,vec_normal);

    }
  
}
