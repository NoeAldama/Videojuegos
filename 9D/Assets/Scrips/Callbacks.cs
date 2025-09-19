using UnityEngine;

public class Callbacks : MonoBehaviour
{
    public float speed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");// a -1, 0, d 1
        float vertical = Input.GetAxis("Vertical"); // w 1, 0 , s- 1
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        //transform.position += direction * (speed * Time.deltaTime); //El objeto se mueve dependiente de los frame que se de declaren al objeto
        transform.Translate(direction * (speed * Time.deltaTime));
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(0f, 180f * Time.deltaTime, 0f);
        }
    }
}
 