using UnityEngine;

public class PlayerController: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //차량을 앞으로 이동합니다.
        transform.Translate(Vector3.forward*Time.deltaTime*20);
    }
}
