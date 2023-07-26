using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float forward_force_z = 20f;
    public float player_speed_xy = 10f;
    public float max_x, min_x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, min_x, max_x);       
        transform.position = playerPos;

        if(Input.GetKey("d"))
        {
            transform.position =  transform.position + new Vector3(player_speed_xy*Time.deltaTime, 0, 0);
        }



        if(Input.GetKey("a"))
        {
            transform.position =  transform.position + new Vector3(-player_speed_xy*Time.deltaTime, 0, 0);
        }

       
    } 


    void FixedUpdate()
    {
        rigidbody.AddForce(0, 0, forward_force_z*Time.deltaTime, ForceMode.Impulse);
    }  
}
