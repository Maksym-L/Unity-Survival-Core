using UnityEngine;

public class Moving : MonoBehaviour
{
    [SerializeField] private float speed;


    void Update()
    {
        Move();
    }

    private void Move()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector3 translation = new Vector3(moveX, moveY, 0).normalized * speed * Time.deltaTime;

        transform.Translate(translation);
    }
}
