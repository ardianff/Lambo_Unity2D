using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{


    //membuat variabel yang menjadi target
    //untuk diikuti oleh Camera
    [SerializeField] private Transform target;


    private void Update()
    {
        //this.transform.position maksutnya adalah Camera
        //terus setiap ada update maka posisi Camera persisnya
        //pada sumbu x akan bertambah atau berkurang sesuai dengan
        //sumbu x yang ada pada Player
        this.transform.position = new Vector3(target.transform.position.x, target.transform.position.y, target.transform.position.z - 10f);
    }
}