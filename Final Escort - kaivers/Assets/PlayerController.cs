using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Vector3 input;

    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed = 5;
    [SerializeField] private Transform trans;
    [SerializeField] private float turnSpeed = 360;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update(){
        GatherInput();
        Look();

    }

    void FixedUpdate(){
        Move();
    }


    void GatherInput(){
        input = new Vector3(Input.GetAxisRaw("Horizontal"),0,Input.GetAxisRaw("Vertical"));

    }

    void Look(){
        var relative = (trans.position + input) - trans.position; // don't get why this is like that, why isnt it just input ?
        //var relative = input;
        var rot = Quaternion.LookRotation(relative, Vector3.up); //look into the inputted direction but rotate the character toward it, vector3.up defines up direction, all is relative to that?
        transform.rotation = Quaternion.RotateTowards(trans.rotation, rot, turnSpeed * Time.deltaTime); //instead of setting trans.rot = rot, we can lerp it 
    }

    void Move(){
        rb.MovePosition(trans.position + trans.forward * input.magnitude * speed * Time.deltaTime); //tranform.forward takes into account the rotation of the obj. as opposed to new vector3.forward
    }

}
