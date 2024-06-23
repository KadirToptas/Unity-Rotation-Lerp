using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpRotation : MonoBehaviour
{
    [SerializeField] private Vector3[] angles;
    [SerializeField] [Range(0,10f)] private float lerpTime;
    [SerializeField] private float _time;
    private float currentTime;
    private int angleIndex;
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(angles[angleIndex]),lerpTime*Time.deltaTime );

        if (currentTime <= 0)
        {
            currentTime = _time;
            angleIndex++;
        }
        else
        {
            currentTime -= Time.deltaTime;  
        }

        if (angleIndex >= angles.Length)
        {
            angleIndex = 0;
        }
    }
}
