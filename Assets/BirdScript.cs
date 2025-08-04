using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public LogicScript logicScript;
    public bool birdIsAlive = true;

    public float heightOfSet = 10;

    public Rigidbody2D myRigidBody; // แก้ชื่อให้ตรงกัน
    public float flapForce = 10f;

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        logicScript.gameOver();
        birdIsAlive = false;
    }

    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && birdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * flapForce * 2;
        }
    }
}


