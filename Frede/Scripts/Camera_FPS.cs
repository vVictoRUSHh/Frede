using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class Camera_FPS : MonoBehaviour
{
    [SerializeField] Transform PlayerCamera = null;
    [SerializeField] float mouseSensa = 4f;
    private float cameraPitch = 0.0f;
    [SerializeField] bool lockCursor = true;
    [SerializeField] private float Wspeed = 7f;
    CharacterController characterController = null;
    [SerializeField] private Text ScoreText;
    private int score = 0;
    [SerializeField] private GameObject Playereban;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;


        }



    }


    void Update()
    {
        MouseUpdate();
        MovementUpdate();
    }




    void MouseUpdate()


    {

        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        cameraPitch -= mouseDelta.y * mouseSensa;
        cameraPitch = Mathf.Clamp(cameraPitch, -90.0f, 90.0f);
        PlayerCamera.localEulerAngles = Vector3.right * cameraPitch;
        transform.Rotate(Vector3.up * mouseDelta.x * mouseSensa);

    }


    void MovementUpdate()

    {
        Vector2 inputDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        inputDir.Normalize();
        Vector3 velocity = (transform.forward * inputDir.y + transform.right * inputDir.x) * Wspeed;
        characterController.Move(velocity * Time.deltaTime);

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Mishka")
        {
            Destroy(other.gameObject);

            score++;
            ScoreText.text = "Score: " + score;
            if (score < 15)
            {



                ScoreText.text = "Score: " + score;
            }


            else
            {


                ScoreText.text = "Òû גûידנאכ ! ";


            }

        }
    }

    
}
