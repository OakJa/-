using UnityEngine;

public class pipecript : MonoBehaviour
{
    public LogicScript logicScript;
    public float baseSpeed = 10f; // Base speed of the pipe
    public float moveSpeed; // Assuming playerScore is accessible here, otherwise pass it as a parameter
   
    public float deadZone = -50;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LogicScript logic = FindObjectOfType<LogicScript>();
        int playerScore = logic != null ? logic.playerScore : 0;

        // คำนวณความเร็วที่เพิ่มขึ้นตามคะแนน
        moveSpeed = baseSpeed + playerScore * 0.7f; // Adjust the multiplier as needed

        // ให้วัตถุเคลื่อนที่
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone)
            Destroy(gameObject);
    }
}
