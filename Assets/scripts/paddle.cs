using UnityEngine;

public class paddle : MonoBehaviour
{
    public float speed = 4f;
    public string leftOrRight;


    // Start is called before the first frame update

    void setKeyAndMovement(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up) && transform.position.y <= 4)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y >= -4)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()




    {
        if (leftOrRight == "left")
        {
            setKeyAndMovement(KeyCode.W, KeyCode.S);
        }
        else if (leftOrRight == "right")
        {
            setKeyAndMovement(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
