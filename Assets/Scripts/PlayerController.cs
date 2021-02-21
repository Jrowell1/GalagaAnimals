using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 20.0f;
    public GameObject projectilePrefab;

    //Health Tracking
    public float health = 100;
    public float foodHealth = 10;
    public float animalDamage = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0){
            //END GAME CONDTIONS
            Debug.Log("GAME OVER!!");
            Destroy(gameObject);
        }

        horizontalInput = Input.GetAxis("Horizontal");

        if(transform.position.x < -xRange){
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        } else if(transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if(Input.GetKeyDown(KeyCode.Space)){
            //Launch projective from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        //Add Health Tracking, Animals do damage and Food increase health 

        //Get Collisions, Food Tag or Animal tag will determine change
        //Psudep
        /*if collisionObject.tag == "animal"
            health - animalDamage;
        else if collisionObject.tag == "food"
            health + foodHealth;
        */

        
    }
}
