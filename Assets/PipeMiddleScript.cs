using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logicScript;
    void Start() { logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); }
    void Update() { }
    private void OnTriggerEnter2D(Collider2D other) { logicScript.addScore(); }

    // Start is called once before the first execution of Update after the MonoBehaviour is created

}