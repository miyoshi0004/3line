using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class itemManager : MonoBehaviour
{

    [SerializeField] int [] st = {0,1,2,3,4};
    [SerializeField] public GameObject star;
    [SerializeField] public GameObject star2;
    [SerializeField] public GameObject star3;
    [SerializeField] public GameObject star4;
    [SerializeField] public GameObject star5;

    Random str = new Random();
    int v = 0;

    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CriaetSter", 5f, 2f);

    }

    // Update is called once per frame
    void Update()
    {
        

        
    }
    public void CriaetSter()
    {
        v = Random.Range(0, 6);
        if(v == 0)
        {
            star.SetActive(true);
        }
        if (v == 1)
        {
            star2.SetActive(true);
        }
        if (v == 2)
        {
            star3.SetActive(true);
        }
        if (v == 3)
        {
            star4.SetActive(true);
        }
        if (v == 4)
        {
            star5.SetActive(true);
        }
    }

    
}
