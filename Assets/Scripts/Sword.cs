using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    private Vector3 myVector;
    void Update()
    {
        SwordRotating();
    }
    private void SwordRotating() 
    {
        transform.Rotate(transform.forward, - rotationSpeed * Time.deltaTime);
    }
}
