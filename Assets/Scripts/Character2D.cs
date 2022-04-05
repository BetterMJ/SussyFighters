using UnityEngine;

public class Character2D : MonoBehaviour
{
    //Player1
    [SerializeField]
    private GameObject Player1;

    private Rigidbody2D _rigidbody1;

    //Player2
    [SerializeField]
    private GameObject Player2;

    private Rigidbody2D _rigidbody2;

    //Main
    public float MovementSpeed = 500;
    public float JumpForce = 1000;

   // public CircleCollider2D cc1;
    //public CircleCollider2D cc2;

    //Animation
    //public Animator animator1;
    //public Animator animator2;

    void Start()
    {
        //Player1
        _rigidbody1 = Player1.GetComponent<Rigidbody2D>();

        //Player2
        _rigidbody2 = Player2.GetComponent<Rigidbody2D>();

        //cc1.enabled = false;
        //cc2.enabled = false;
    }

    void Update()
    {
        //Attack
        /*if (Input.GetButtonDown("AttackPlayer1"))
        {
            animator1.SetBool("AttackPlayer1", true);
            cc1.enabled = true;
        }
        if (Input.GetButtonUp("AttackPlayer1"))
        {
            animator1.SetBool("AttackPlayer1", false);
            cc1.enabled = false;
        }

        animator2.SetBool("HorizontalPlayer2", Input.GetButtonDown("HorizontalPlayer2"));
        //animator2.SetBool("AttackPlayer2", Input.GetButtonDown("AttackPlayer2"));
        if (Input.GetButtonDown("AttackPlayer2"))
        {
            animator2.SetBool("AttackPlayer2", true);
            cc2.enabled = true;
        }
        if (Input.GetButtonUp("AttackPlayer2"))
        {
            animator2.SetBool("AttackPlayer2", false);
            cc2.enabled = false;
        }*/

        //Movement
        //Player1

        var movementPlayer1 = Input.GetAxis("HorizontalPlayer1");
        Player1.transform.position += new Vector3(movementPlayer1, 0, 0) * Time.deltaTime * MovementSpeed;

        if (!Mathf.Approximately(0, movementPlayer1))
            Player1.transform.rotation = movementPlayer1 < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

        if (Input.GetButtonDown("JumpPlayer1") && Mathf.Abs(_rigidbody1.velocity.y) < 0.001f)
        {
            _rigidbody1.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }



        //Player2

        var movementPlayer2 = Input.GetAxis("HorizontalPlayer2");
        Player2.transform.position += new Vector3(movementPlayer2, 0, 0) * Time.deltaTime * MovementSpeed;

        if (!Mathf.Approximately(0, movementPlayer2))
            Player2.transform.rotation = movementPlayer2 < 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;

        if (Input.GetButtonDown("JumpPlayer2") && Mathf.Abs(_rigidbody2.velocity.y) < 0.001f)
        {
            _rigidbody2.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}
