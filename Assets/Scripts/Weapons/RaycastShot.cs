using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastShot : MonoBehaviour
{
    public Camera PlayerCamera;
    public float FireRate = 10f;
    private float timeBetweenNextShot;

    void Update()
    {
        if(Input.GetButton("Fire1")&& Time.time >= timeBetweenNextShot){
            timeBetweenNextShot = Time.time + 1f/FireRate;
            weapon();
        }
    }
    void weapon(){
        RaycastHit hit;
        if(Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward,out hit)){
            Debug.Log(hit.transform.name);
        }
    }
}
