using UnityEngine;
using UnityEngine.UI; // เพิ่มบรรทัดนี้
using UnityEngine.SceneManagement; // เพิ่มบรรทัดนี้

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1 ;
        scoreText.text = playerScore.ToString();
    }

   public void restartGame(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
    
    public GameObject gameOverScreen;
        
    public void gameOver(){
    gameOverScreen.SetActive(true);
}
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // สามารถเพิ่มเติมการตั้งค่าเริ่มต้นได้ที่นี่
    }

    // Update is called once per frame
    void Update()
    {

    }
}