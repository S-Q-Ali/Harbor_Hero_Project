using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 40f;
    private float turnSpeed = 25f;
    private float horizontalInput;
    private float verticalInput;

    private GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        Audio.instance.oceansource.PlayOneShot(Audio.instance.oceansound);
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
      
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Rock"))
        {
            Audio.instance.crashsource.PlayOneShot(Audio.instance.crashsound);
            gm.DecreaseHealth1();
        }

        if (collision.gameObject.CompareTag("Opponent"))
        {
            Audio.instance.crashsource.PlayOneShot(Audio.instance.crashsound);
            gm.DecreaseHealth2();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            Audio.instance.victorysource.PlayOneShot(Audio.instance.victorysound);
            gm.WonText.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

}

