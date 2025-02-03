using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(transform.position.x > -9)
            transform.Translate(-3, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (transform.position.x < 9)
                transform.Translate(3, 0, 0);
        }
        
    }
    public void LButtonDown()
    {
        if (transform.position.x > -9)
            transform.Translate(-3, 0, 0);
    }

    public void RButtonDown()
    {
        if (transform.position.x < 9)
            transform.Translate(3, 0, 0);
    }
}
