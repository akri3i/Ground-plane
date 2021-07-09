using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public int yv;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = new Vector3(0, yv, 0);
        transform.Rotate(vector * Time.deltaTime);
    }
}
