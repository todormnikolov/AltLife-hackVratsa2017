using UnityEngine;

public class SimpleController : MonoBehaviour
{
    public float speed = 6.0F;
    public float gravity = 20.0F;
    [Space]
    public CharacterController controller;
    public Animator charAnimator;

    private int walkToHash;
    private int idleToHash;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        // Store reference to attached component
        controller = GetComponent<CharacterController>();
        walkToHash = Animator.StringToHash("Base Layer.WALK");
        idleToHash = Animator.StringToHash("Base Layer.IDLE");

    }

    void Update()
    {

        // Use input up and down for direction, multiplied by speed
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;


        // Move Character Controller
        if (moveDirection.magnitude > 0.001)
        {
            charAnimator.Play(walkToHash);
            controller.Move(moveDirection * Time.deltaTime);
        }
        else
        {
            charAnimator.Play(idleToHash);
        }
    }
}
