using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateMe : MonoBehaviour
{
    private Transform _tf;

    private void Awake()
    {
        _tf = GetComponent<Transform>();
    }


    private void Update()
    {
        _tf.Rotate(new Vector3(0, 0, Time.deltaTime * 100f));


    }


}
