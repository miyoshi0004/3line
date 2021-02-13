using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rool : MonoBehaviour
{
    public GameObject cube;
    float[] rol = { 0, 90, 180 };
    Random random = new Random();
    int stage = 0;

    // Start is called before the first frame update
    void Start()
    {
        Transform myTransform = this.transform;

        Vector3 worldAngle = myTransform.eulerAngles;
        stage = Random.Range(0, 3);
        worldAngle.z = rol[stage];
        myTransform.eulerAngles = worldAngle;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
