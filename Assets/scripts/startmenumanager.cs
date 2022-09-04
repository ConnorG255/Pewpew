using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startmenumanager : MonoBehaviour
{
    // Start is called before the first frame update
     public float option = 0;
    public GameObject sw;
    public GameObject ow;
    public GameObject qw;
    public GameObject V;
    public float vol2 = 0.2f;


    public float vol = 10;
    void Start()
    {
        
    }

    void updattext()
    {
        vol2 = vol / 20;
        V.GetComponent<UnityEngine.UI.Text>().text = "Volume " + vol2.ToString();
    }
    // Update is called once per frame
    void Update()
    {
  
        updattext();

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            option -= 1;
            if (option < 0)
            {
                option = 2;//maxlegn
            }
        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            option += 1;
            if (option > 2)
            {
                option = 0;//maxlegn
            }
        }



        if (option == 1 && Input.GetKeyDown(KeyCode.LeftArrow) && vol > 1 && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("dododo"))
        {
            vol = vol - 1;
            
        }
        if (option == 1 && Input.GetKeyDown(KeyCode.RightArrow) && vol < 19 && SceneManager.GetActiveScene() == SceneManager.GetSceneByName("dododo") ) 
        {
            vol = vol + 1;
            
        }




        switch (option)
        {
            //have one above and below 
            case 0:
                V.SetActive(false);

                sw.SetActive(true);
                qw.SetActive(false);
                ow.SetActive(false);
                break;
            case 1:
                V.SetActive(true);

                ow.SetActive(true);
                sw.SetActive(false);
                qw.SetActive(false);
                break;
            case 2:
                V.SetActive(false);

                qw.SetActive(true);
                sw.SetActive(false);
                ow.SetActive(false);
                break;

        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            switch (option)
            {
                //have one above and below 
                case 0:
                    SceneManager.LoadScene("SampleScene");
                    break;
                case 1:
                    
                    break;
                case 2:
                    Application.Quit();
                    break;

            }
        }
    }
}
