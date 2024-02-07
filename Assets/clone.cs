using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clone : MonoBehaviour
{
    public GameObject pipe;
    public float height;

    private float timer = 0;
    public float MaxTime = 2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(pipe); 
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer>MaxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 15); // Destroy() удаляет объект. Первый параметр - объект для удаления, второй - время в с
            timer = 0;
        }

        timer += Time.deltaTime;        
    }
}
