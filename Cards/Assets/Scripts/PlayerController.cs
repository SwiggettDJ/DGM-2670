using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public FloatSO speed;
    public float jumpHeight = 30f;
    private float turn;
    private float outOfBounds;
    public UnityEvent outOfBoundsEvent;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        turn = 1f;
        outOfBounds = -20f;
        speed.clear();
    }
    

    void FixedUpdate()
    {
        transform.Translate(Vector3.right * speed.value * Time.deltaTime *turn);
        if (transform.position.y < outOfBounds)
        {
            outOfBoundsEvent.Invoke();
        }
        
    }

    public void Jump()
    {
        rb.AddForce(0,jumpHeight,0, ForceMode.Impulse);
    }

    public void Turn()
    {
        turn *= -1f;
    }

    public void SpeedBoost()
    {
        rb.AddForce(12f*turn,0,0, ForceMode.Impulse);
    }
    
}
