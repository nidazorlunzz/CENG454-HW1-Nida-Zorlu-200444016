using UnityEngine;

public class FlightController : MonoBehaviour
{
    [SerializeField] private float pitchSpeed = 60f;   // Up / Down
    [SerializeField] private float yawSpeed = 60f;     // Left / Right
    [SerializeField] private float rollSpeed = 80f;    // Q / E
    [SerializeField] private float thrustSpeed = 15f;  // Space

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.freezeRotation = true;

    
        rb.useGravity = false;
    }

    void Update()
    {
        HandleRotation();
        HandleThrust();
    }

    private void HandleRotation()
    {
        float pitch = 0f;
        float yaw = 0f;
        float roll = 0f;

        if (Input.GetKey(KeyCode.UpArrow))
            pitch = -pitchSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.DownArrow))
            pitch = pitchSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
            yaw = -yawSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.RightArrow))
            yaw = yawSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.Q))
            roll = rollSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
            roll = -rollSpeed * Time.deltaTime;

        transform.Rotate(Vector3.right * pitch);
        transform.Rotate(Vector3.up * yaw);
        transform.Rotate(Vector3.forward * roll);
    }

    private void HandleThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * thrustSpeed * Time.deltaTime);
        }
    }
}