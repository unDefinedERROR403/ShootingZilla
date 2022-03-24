using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombiemovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         // Move the object forward along its z axis 1 unit/second.

        transform.Translate(Vector3.forward * Time.deltaTime *0.3f);

        // Rotate the camera every frame so it keeps looking at the target
        
        transform.LookAt(Camera.main.transform.position);

        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
    }
}
