using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float hp;
    private float score = 0;
    [SerializeField] private float shlimakCount;
    [SerializeField] private Canvas gameOver;
    [SerializeField] private GameObject sw2;
    [SerializeField] private GameObject sw3;
    [SerializeField] private GameObject sw4;
    [SerializeField] private TextMeshProUGUI maxScoreText;
    [SerializeField] private TextMeshProUGUI actualScoreText;

    public float Score { get => score; set => score = value; }
    public float ShlimakCount { get => shlimakCount; set => shlimakCount = value; }
    
    public void TakeDamage()
    {
        hp -= 1;
        if (hp <= 0) 
        {
            Debug.Log("You lose");
            actualScoreText.text = ("Your finish score is " + score).ToString();
            if (PlayerPrefs.GetFloat("MaxScoreLT", 0) <= score) 
            {
                PlayerPrefs.SetFloat("MaxScoreLT", score);
            }
            Debug.Log("Your max score was " + PlayerPrefs.GetFloat("MaxScoreLT"));
            maxScoreText.text = "Your Maximal score is " + PlayerPrefs.GetFloat("MaxScoreLT").ToString();
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private void Start()
    {
        Debug.Log("To delete your old record, just push the backspace button Down");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            PlayerPrefs.DeleteKey("MaxScoreLT");
        }
    }
    public void LevelUp() 
    {
        if (!sw2.activeSelf)
        {
            sw2.SetActive(true);
        }
        else 
        {
            sw3.SetActive(true);
            sw4.SetActive(true);
        }
    }
}
