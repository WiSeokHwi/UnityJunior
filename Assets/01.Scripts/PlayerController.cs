using UnityEngine;

public class PlayerController: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float speed = 20.0f;
    private float trunSpeed=45.0f;
    private float horizontalInput;
    private float forwardInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //차량을 앞으로 이동합니다.
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput);
        transform.Rotate(Vector3.up,trunSpeed * Time.deltaTime * horizontalInput);

    }
}
