using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float Speed = 0;
    Vector2 stardPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.stardPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.x - stardPos.x;
            this.Speed = swipeLength / 500.0f;
            GetComponent<AudioSource>().Play();

        }
        transform.Translate(this.Speed, 0, 0);
        this.Speed *= 0.98f;



    }
}
