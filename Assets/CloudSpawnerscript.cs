using UnityEngine;

public class CloudSpawnerScript : MonoBehaviour
{
    public GameObject Cloud; // ถ้าเป็น Cloud ให้ชื่อนี้
    public float spawnTime = 3f; // ค่าทำเป็น float

    private float timer = 0f;

    public float heightOfSet = 3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            float minY = transform.position.y - heightOfSet;
            float maxY = transform.position.y + heightOfSet;

            // ถ้าต้องการ spawn Cloud ไม่ใช่ Pipe ก็ใช้ Cloud แทน
            Instantiate(Cloud, new Vector3(transform.position.x, Random.Range(minY, maxY), 0), Quaternion.identity);
            timer = 0f;
        }
    }
}