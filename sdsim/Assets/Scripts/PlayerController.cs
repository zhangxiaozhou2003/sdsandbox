using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject RosConnect;
    private Rigidbody rb;

    // public float speed = 5.0f;
    private Vector3[] positionsArray = new [] { new Vector3(0f,0.5f,1f),
                                              new Vector3(0f,0.5f,2f),
                                              new Vector3(0f,0.5f,3f),
                                              new Vector3(0f,0.5f,4f),
                                              new Vector3(0f,0.5f,5f),
                                              new Vector3(0f,0.5f,6f),
                                              new Vector3(0f,0.5f,7f),
                                              new Vector3(0f,0.5f,8f)};
    private Quaternion[] rotationsArray = new [] { Quaternion.Euler(0, -15.0f, 0),
                                                 Quaternion.Euler(0, -30.0f, 0),
                                                 Quaternion.Euler(0, -45.0f, 0),
                                                 Quaternion.Euler(0, -60.0f, 0),
                                                 Quaternion.Euler(0, -75.0f, 0),
                                                 Quaternion.Euler(0, -90.0f, 0),
                                                 Quaternion.Euler(0, -105.0f, 0),
                                                 Quaternion.Euler(0, -120.0f, 0) };

    // public float movementSpeed = 5.0f;
    // public float clockwise = 5.0f;
    // public float counterClockwise = -5.0f;

    // Start is called before the first frame update
    void Awake()
    {
        RosConnect = GameObject.Find("RosConnector");
    }
    void Start(){

    }
    // IEnumerator Start()
    // {
    //     // poseRos.Position.X;
    //
    //     rb =  GetComponent<Rigidbody> ();
    //     rb.useGravity = false;
    //     rb.detectCollisions = false;
    //     Debug.Log(positionsArray.Length);
    //     for (int i=0; i<8; ++i) {
    //         yield return new WaitForSeconds(1f);
    //         Vector3 target_p = positionsArray[i];
    //         Quaternion target_r = rotationsArray[i];
    //         rb.transform.position = target_p;
    //         rb.transform.rotation = target_r;
    //         Debug.Log("try it " + RosConnect.GetComponent<RosSharp.RosBridgeClient.PoseStampedSubscriber>().position[0]);
    //     }
    //
    // }

    // Update is called once per frame
    void Update()
    {
        rb =  GetComponent<Rigidbody> ();
        rb.useGravity = false;
        rb.detectCollisions = false;
        Vector3 oldFramePos = RosConnect.GetComponent<RosSharp.RosBridgeClient.PoseStampedSubscriber>().position;
        rb.transform.position = new Vector3(oldFramePos[2], -oldFramePos[0],oldFramePos[1]);
        Quaternion oldFrameRot = RosConnect.GetComponent<RosSharp.RosBridgeClient.PoseStampedSubscriber>().rotation;
        rb.transform.rotation = Quaternion.Euler(-oldFrameRot[2], oldFrameRot[0],-oldFrameRot[1]);


        // float step = speed * Time.deltaTime;
        // Vector3 target_p = new Vector3 (1.0f, 0.5f, 1.0f);
        // Quaternion target_r = Quaternion.Euler(0, -90.0f, 0);
        // // rb.transform.position = Vector3.MoveTowards(rb.transform.position, target_p, step);
        // // rb.transform.rotation = Quaternion.RotateTowards(rb.transform.rotation, target_r,  step);
        // rb.transform.position = target_p;
        // rb.transform.rotation = target_r;
        // rb.transform.rotation = target_r;
        // transform.Translate(Vector3.forward * Time.deltaTime * speed);
    //     if(Input.GetKey(KeyCode.W)) {
    //         transform.position += transform.forward * Time.deltaTime * movementSpeed;
    //      }
    //      else if(Input.GetKey(KeyCode.S)) {
    //         transform.position -= transform.forward * Time.deltaTime * movementSpeed;
    //      }
    //      else if(Input.GetKey(KeyCode.A)) {
    //         transform.position -= transform.right * Time.deltaTime * movementSpeed;
    //      }
    //      else if(Input.GetKey(KeyCode.D)) {
    //         transform.position += transform.right * Time.deltaTime * movementSpeed;
    //      }

    //      if(Input.GetKey(KeyCode.E)) {
    //         transform.Rotate(0, Time.deltaTime * clockwise, 0);
    //      }
    //      else if(Input.GetKey(KeyCode.Q)) {
    //         transform.Rotate(0, Time.deltaTime * counterClockwise, 0);
    //      }
    }

    void FixedUpdate() {

        // float moveHorizontal = Input.GetAxis("Horizontal");
        // float moveVertical = Input.GetAxis("Vertical");

        // Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        // rb.AddForce(movement * speed);


    }
}
