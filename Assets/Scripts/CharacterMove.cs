using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMove : MonoBehaviour
{
    public Transform cameraTransform;
    public float movementSpeed = 5f;

    Rigidbody body;
    float horizontal;
    float vertical;
    
    //Jumping
    public Rigidbody rb;
    public float jumpAmount = 10;

    public LayerMask mask;

    void Start()
    {
        body = GetComponent<Rigidbody>();
        

        //Screen.lockCursor = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode.Impulse);
        }
        
        //Interact funktion
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hitinfo;
            bool hit = Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hitinfo, 5f, mask);
            if (hit == true)
            {
                //Debug.Log(hitinfo.transform.name);
                Interactable interact;
                hitinfo.transform.TryGetComponent(out interact);
                if (interact != null)
                {
                    interact.OnInteraction();
                }
            }
        }
        //Menu Button
        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Menu");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void FixedUpdate()
    {
        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        forward.y = 0;
        right.y = 0;

        Vector3 direction = forward * vertical + right * horizontal;

        Vector3 movement = transform.position + direction.normalized * Time.fixedDeltaTime * movementSpeed;

        body.MovePosition(movement);

        if(direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }
    }
}



//Titta på:
//3. Raycast interact knapp


//Att Göra:
//PRIO Start Meny!!
//1. Interakt Mat, Äta den, ljud, frukt försvinner (Mat kommer tillbaka efter X tid)
//2. Flytta möbler
//3. "Haunt Object", Aktivera Hover på grejer
//4. 