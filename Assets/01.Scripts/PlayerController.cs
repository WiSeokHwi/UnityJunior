using UnityEngine;

public class PlayerController: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 5.0f;
    public float trunSpeed;
    public float horizontalInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //������ ������ �̵��մϴ�.
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        transform.Translate(Vector3.right * Time.deltaTime * trunSpeed * horizontalInput);

    }
}
