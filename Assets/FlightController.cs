using UnityEngine;

public class FlightController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    [SerializeField] float pitchSpeed = 150f;
    [SerializeField] float thrustSpeed = 50f;
    [SerializeField] float liftSpeed = 50f;
    
    void Update()
    {
        float pitchInput = Input.GetAxis("Vertical");
        transform.Rotate(-pitchInput * pitchSpeed * Time.deltaTime, 0, 0);
        transform.Translate(Vector3.forward * thrustSpeed * Time.deltaTime, Space.Self);
       
    }
}
