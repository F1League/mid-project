using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBall : MonoBehaviour
{
    public Transform Player; // อ้างอิงถึง Transform ของลูกบอล
    public float distance = 10.0f; // ระยะห่างระหว่างกล้องกับลูกบอล
    public float angleDown = 45.0f; // มุมที่กล้องก้มลงมองลูกบอล
   
    void Update()
    {
        // ตรวจสอบว่ามีลูกบอลหรือไม่
        if (Player != null)
        {
            // หาค่าตำแหน่งใหม่ของกล้องตามตำแหน่งของลูกบอล
            Vector3 newPosition = Player.position - (transform.forward * distance);

            newPosition.y = Player.position.y - Mathf.Tan(angleDown * Mathf.Deg2Rad) * distance;

            // กำหนดให้ตำแหน่งของกล้องเป็นตำแหน่งใหม่
            transform.position = newPosition;

            // หมุนกล้องให้มองเห็นลูกบอล
            transform.LookAt(Player);
        }
    }
}
