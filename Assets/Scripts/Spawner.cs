using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject Schlimack;
    [SerializeField] private int maxCount;
    private int actualKillCount;
    private int actualSpawnCount;
    [SerializeField] private int firstSpawnCount;
    [SerializeField] private Player myPlayer;
    void Update()
    {
        if (actualKillCount > maxCount) 
        {
            Debug.Log("YouWin");
        } 
    }
    public void Spawn() 
    {
        Vector2 vector2 = Vector2.zero;
        int side = Random.Range(1, 5); 
        float sidePercent = Random.Range(0f, 1f);
        Vector2 screenVector = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        switch (side) 
        {
        case 1:
                vector2.x = (screenVector.x * -1);
                vector2.y = (screenVector.y * sidePercent);
                break;
        case 2:
                vector2.x = (screenVector.x * sidePercent);
                vector2.y = (screenVector.y * - 1);
                break;
        case 3:
                vector2.x = (screenVector.x);
                vector2.y = (screenVector.y * sidePercent);
                break;
        case 4:
                vector2.x = (screenVector.x * sidePercent);
                vector2.y = (screenVector.y);
                break;
        }
        GameObject object1; 
        object1 = Instantiate(Schlimack, vector2, Quaternion.identity);
        Enemy enemySchlimack = object1.GetComponent<Enemy>();
        enemySchlimack.MyPlayer = myPlayer;
        enemySchlimack.Spawner = this;
    }
}
