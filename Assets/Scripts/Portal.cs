using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private float offsetUp;
    [SerializeField] private float offsetDown;
    void Start()
    {
        
    }    
    void Update()
    {
        Vector3 myVector = transform.position;
        Vector2 screenVector = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        if (transform.position.x > screenVector.x) 
        {
        myVector.x = screenVector.x * (- 1);
        }
        else if (transform.position.y > screenVector.y + offsetUp)
        {
            myVector.y = screenVector.y * (-1) - offsetDown;
        }
        else if (transform.position.x < - screenVector.x)
        {
            myVector.x = screenVector.x;
        }
        else if (transform.position.y < - screenVector.y - offsetDown)
        {
            myVector.y = screenVector.y + offsetUp;
        }
        transform.position = myVector;
    }
}
