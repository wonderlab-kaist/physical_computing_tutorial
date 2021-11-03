using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_cube : MonoBehaviour
{
    public arduino_communication arduino_;

    private Quaternion origin;
    private bool originated = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tmp = arduino_.getAngles();



        this.transform.rotation = Quaternion.Euler(tmp);
    }
}
