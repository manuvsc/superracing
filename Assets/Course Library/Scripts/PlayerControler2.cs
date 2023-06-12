using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler2 : MonoBehaviour
{
    //vruuuuum
    public float speed = 15.0f;
    public float turnSpeed = 10.0f;
    private float horizontalInput;
    private float verticalInput;
    //take camera
    public GameObject camera1;
    public GameObject camera2;
    private Camera cameraMain;
    private Camera cameraPiloto;
    private bool gameStart;
    void Start()
    {
        cameraMain = camera1.GetComponent<Camera>();
        cameraPiloto = camera2.GetComponent<Camera>();
        gameStart = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameStart)
        {
            //capture input Z
            verticalInput = Input.GetAxis("Vertical2");

            //capture input Y
            horizontalInput = Input.GetAxis("Horizontal2");

            //carrinho para frente e tras
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

            if (verticalInput != 0)
            {
                //girar para fazer curva
                transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                cameraMain.enabled = !cameraMain.enabled;
                cameraPiloto.enabled = !cameraPiloto.enabled;
            }
        }
    }

    public void SetStartPlayer(bool start)
    {
        gameStart = start;
    }
}
