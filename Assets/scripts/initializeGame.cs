using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class initializeGame : MonoBehaviour
{


    
    public GameObject RedCube;  
    public GameObject GreenCube;
    public GameObject BlueCube;
    public GameObject YellowCube;
    public GameObject MagentaCube;
    public GameObject Wall;
    public GameObject fall;
    public GameObject topCheck;
    public GameObject fpsCam;
    public GameObject Spotlight;
    public Button button;
    public InputField input;
    public GameObject CanvasObject;
    public GameObject CanvasObject2;
    public Camera Cam;
    public Text GMOVER;
    public Text Life;
    public Text Score;
    public Text Reserve;
    public static int score = 50;
    public static int life = 3;
    public static int reserve = 0;
    public static int N;



    void Awake()
    {
       
        CanvasObject2.SetActive(false);
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(transfor);

    }


    void transfor()
    {
        N = int.Parse(input.text);
        if (N % 2 == 1)
        {
            N = N + 1;
        }
        createScene(N);
    }
    void createScene(int N) 
    {
        CanvasObject2.SetActive(true);
        Destroy(CanvasObject);

        Destroy(Cam);
        
        int color = 5;


        fall.transform.localScale = new Vector3(2 * N, 1, 2 * N);
        Instantiate(fall, new Vector3(N / 2 + 1, -15, N / 2 + 1), Quaternion.identity);
        Vector3 mid = new Vector3(N / 2, 1, N / 2);
        Wall.transform.localScale = new Vector3(N + 1, N, 1);
        Instantiate(Wall, new Vector3((float)N / 2, (float)(N + 1) / 2, N + 1), Quaternion.identity);
        Instantiate(Wall, new Vector3((float)N / 2, (float)(N + 1) / 2, N - (N + 1)), Quaternion.identity);
        Wall.transform.localScale = new Vector3(1, N, N + 1);
        Instantiate(Wall, new Vector3((N - (N + 1)), (float)(N + 1) / 2, (float)N / 2), Quaternion.identity);
        Instantiate(Wall, new Vector3(N + 1, (float)(N + 1) / 2, (float)N / 2), Quaternion.identity);
        Instantiate(MagentaCube, new Vector3(N / 2, 1, N / 2), Quaternion.identity);
        Instantiate(fpsCam, new Vector3(N / 2, 1.5F, N / 2), Quaternion.identity);
      
        for (int i = 0; i <= N; i++)
        {
            for (int j = 0; j <= N; j++)
            {
                Vector3 Position = new Vector3(i, 1, j);
                if (Position != mid)
                {
                    color = Random.Range(1, 5);

                    if (color == 1)
                    {
                        Instantiate(RedCube, new Vector3(i, 1, j), Quaternion.identity);
                    }
                    else if (color == 2)
                    {
                        Instantiate(GreenCube, new Vector3(i, 1, j), Quaternion.identity);
                    }
                    else if (color == 3)
                    {
                        Instantiate(BlueCube, new Vector3(i, 1, j), Quaternion.identity);
                    }
                    else if (color == 4)
                    {
                        Instantiate(YellowCube, new Vector3(i, 1, j), Quaternion.identity);
                    }

                }
            }

        }

        topCheck.transform.localScale = new Vector3(N, 0.5F, N);
        Instantiate(topCheck, new Vector3(N / 2, N, N / 2), Quaternion.identity);
        if (N > 130)
        {

            Instantiate(Spotlight, new Vector3(0, N, 0), Quaternion.Euler(90, 100, 0));
            Instantiate(Spotlight, new Vector3(N, N, 0), Quaternion.Euler(90, 100, 0));
            Instantiate(Spotlight, new Vector3(0, N, N), Quaternion.Euler(84, 510, 0));
            Instantiate(Spotlight, new Vector3(N, N, N), Quaternion.Euler(100, 30, 0));
        }
        else
        {
            Instantiate(Spotlight, new Vector3(0, N / 1.3f, 0), Quaternion.Euler(90, 100, 0));
            Instantiate(Spotlight, new Vector3(N, N / 1.3f, 0), Quaternion.Euler(90, 100, 0));
            Instantiate(Spotlight, new Vector3(0, N / 1.3f, N), Quaternion.Euler(84, 510, 0));
            Instantiate(Spotlight, new Vector3(N, N / 1.3f, N), Quaternion.Euler(100, 30, 0));
        }
    }
    void Update()
    {
        Score.text = "Score = " + score.ToString();
        Life.text = "Life = " + life.ToString();
        Reserve.text = "Reserve = " + reserve.ToString();
        if (life <= 0)
        {
           
            GMOVER.text = "GAME OVER";           
        }

    }
}
