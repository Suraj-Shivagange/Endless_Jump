using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Transform Player;
    float playerHeightY;


    public Transform regular;
    public Transform jump;
    public Transform LeftRight;
    public Transform UpDown;

    private int platNumber;

    private float platCheck;
    private float spawnPlatformTo;


    void Start()
    {       
            Player = GameObject.Find("egg3").transform;

        PlatformSpawner(-0.45f);



    }
    // Update is called once per frame
    void Update()
    {
        playerHeightY = Player.position.y;

        if(playerHeightY > platCheck)
        {
            PlatformManager();
        }

        float currentCameraHeight = transform.position.y;

        float newHeightOfCamera = Mathf.Lerp(currentCameraHeight, playerHeightY, Time.deltaTime * 10);

        if(playerHeightY > currentCameraHeight)
        {
            transform.position = new Vector3(transform.position.x, newHeightOfCamera, transform.position.z);
        }
        else
        {
            if (playerHeightY < (currentCameraHeight - 0.8f))
            {
                OnGUI2D.OG2D.CheckHighScore();
                SceneManager.LoadScene(1);
            }
        }

        //TAKES OUR PLAYERS CURRENT Y  AND ASSIGNS IT IF HIGHER THEN OUR CURRENT SCORE.. TO OUR SCORE
        if (playerHeightY > OnGUI2D.score)
        {
            // ASSIGNS SCORE VAR TO A INT BASED OFF OUR PLAYER HEIGHT Y
            OnGUI2D.score = (int)playerHeightY;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    void PlatformManager()
    {
        platCheck = Player.position.y + 15;

        PlatformSpawner(platCheck + 15);
    }

    void PlatformSpawner(float floatValue)
    {

        float y = spawnPlatformTo;

        while (y <= floatValue)
        {
            float x = Random.Range(-0.447f, 0.484f);

            platNumber = Random.Range(1, 5);

            Vector2 posXY = new Vector2(x, y);

            if (platNumber == 1)
            {

                Instantiate(regular, posXY, Quaternion.identity);

            }
            if (platNumber == 2)
            {
                Instantiate(jump, posXY, Quaternion.identity);
            }
            if (platNumber == 3)
            {
                Instantiate(LeftRight, posXY, Quaternion.identity);
            }
            if (platNumber == 4)
            {
                Instantiate(UpDown, posXY, Quaternion.identity);
            }

            y += Random.Range(.1f,.5f);
            Debug.Log("Spawned Platform");
        }
        spawnPlatformTo = floatValue;
    }


}
