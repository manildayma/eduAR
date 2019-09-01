using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtScript : MonoBehaviour
{
    
        GameObject target, cameraPosition;

    void Start(){ target = GameObject.Find("finder"); }

    void Update(){ transform.LookAt(target.transform); }
}
