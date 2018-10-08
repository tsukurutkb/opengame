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
        Vector3 forward_vec=transform.forward;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        rigid.velocity=(transform.forward*z);
        Quaternion rot;
        rot=Quaternion.AngleAxis(x,transform.up);
        transform.rotation*=rot;
        if (Physics.Raycast(transform.position, -transform.up, out hit, float.PositiveInfinity))//球体に添わせるために開店をする
        {
            Vector3 projected_vec=Vector3.ProjectOnPlane(transform.forward,hit.normal);
            projected_vec.Normalize();
            Debug.Log(projected_vec);
            transform.rotation=Quaternion.LookRotation(projected_vec,hit.normal);
           // Quaternion q = Quaternion.FromToRotation(transform.up, hit.normal);
           // transform.rotation *= q;
        }

    }
  
}
