using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float Xspeed;
    public float Yspeed;


    // Start is called before the first frame update
    void Start()
    {
        Xspeed = 1f;
        Yspeed = 1f;

    }

    // Update is called once per frame
    void Update()
    {
        Xposition += Xspeed * Time.deltaTime;
        Yposition += Yspeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HorizontalWall"))
        {
            Yspeed = Yspeed * -1;
        }
        if (collision.gameObject.CompareTag("VerticalWall"))
        {
            Xspeed = Xspeed * -1;
        }
        if (collision.gameObject.CompareTag("player1"))
        {
            Xspeed = Xspeed * -1;
        }
        if (collision.gameObject.CompareTag("player2"))
        {
            Xspeed = Xspeed * -1;
        }
        if (collision.gameObject.CompareTag("player"))
        {
            Xspeed = Xspeed * -1;
        }
        if (collision.gameObject.CompareTag("VerticalWall"))
        {
            Xspeed = Xspeed * -1;
        }

    }
}