using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private Vector2 myVector;
    [SerializeField] private float speed;
    [SerializeField] private int maxHp = 3;
    private Player myPlayer;
    private int actualHp;
    private Spawner spawner;

    public Player MyPlayer { get => myPlayer; set => myPlayer = value; }
    public Spawner Spawner { get => spawner; set => spawner = value; }

    void Start()
    {
        actualHp = maxHp;
        myVector = Random.insideUnitSphere;
        rb.linearVelocity = myVector.normalized * speed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player>().TakeDamage();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Sword"))
        {
            TakeDamage();
        }
    }
    public void TakeDamage() 
    {
        actualHp -= 1;
        Debug.Log("-1hp");
        if (actualHp <= 0) 
        {
            MyPlayer.Score += 1;
            spawner.Spawn();
            Debug.Log(MyPlayer.Score);
            Destroy(gameObject);
        }
    }
}
