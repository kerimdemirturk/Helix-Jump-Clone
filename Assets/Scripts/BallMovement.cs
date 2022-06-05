using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpingForce;
    public GameObject splashPrefab;
    private GameManager gm;
    public Image Pass;
        


    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up * jumpingForce);
        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        GameObject splash = Instantiate(splashPrefab,transform.position-new Vector3(0,0.2f,0),transform.rotation);
        splash.transform.SetParent(other.transform);

        if(materialName=="wrongPozition")
        {
            gm.RestartGame();
        }
        else if(materialName=="endGameMaterial")
        {
            Debug.Log(Pass);
        }
    }
}
