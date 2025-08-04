using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public float moveSpeed = 1000; // ปรับเป็นความเร็วที่เหมาะสม
    public float deadZone = -50f; // ตำแหน่งที่จะทำลายวัตถุเมื่อเลย

    void Start()
    {
        // ไม่จำเป็นต้องใส่โค้ดใน Start() หากไม่มีอะไรเพิ่มเติม
    }

    void Update()
    {
        // เคลื่อนที่วัตถุไปด้านซ้าย
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        // ถ้าตำแหน่ง x น้อยกว่าจุด deadZone ก็ทำลายวัตถุ
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}