using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D player;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        if (player == null)
            Debug.LogError("Player에 Rigidbody2D 없음");

        player.bodyType = RigidbodyType2D.Kinematic; // 떨림 없이 이동
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(h, v, 0f) * speed * Time.fixedDeltaTime;
        transform.position += move; 
    }
}
