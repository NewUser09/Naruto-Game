using UnityEngine;

public class UIHorizontalMove : MonoBehaviour
{
    public float distance = 50f;
    public float speed = 2f;
    public bool moveRight = true;

    private RectTransform rect;
    private Vector2 startPos;

    void Start()
    {
        rect = GetComponent<RectTransform>();
        startPos = rect.anchoredPosition;
    }

    void Update()
    {
        float move = Mathf.PingPong(Time.time * speed, distance);

        if (moveRight)
        {
            rect.anchoredPosition = new Vector2(startPos.x + move, startPos.y);
        }
        else
        {
            rect.anchoredPosition = new Vector2(startPos.x - move, startPos.y);
        }
    }
}