using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public LogicScript logicScript;
    public bool birdIsAlive = true;

    public float heightOfSet = 10;

    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        logicScript.gameOver();
        birdIsAlive = false;
    }
    public Rigidbody2D myRigibody;
    public float flapForce = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive) {
            myRigibody.velocity = Vector2.up * 2 *heightOfSet;
        }
    }
   
}

