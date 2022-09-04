using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textupdater : MonoBehaviour
{
    public GameObject Scoretext;
    public GameObject Sscoretext;
    public GameObject Livetext;
    public GameObject player;
    float p = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameManVar var = player.GetComponent<GameManVar>();
        Player varp = player.GetComponent<Player>();
        p = var.power / 20;
        Scoretext.GetComponent<UnityEngine.UI.Text>().text = "Power: " + p.ToString();
            Livetext.GetComponent<UnityEngine.UI.Text>().text = "Lives: " + varp.lives.ToString();
        Sscoretext.GetComponent<UnityEngine.UI.Text>().text = "Score: " + varp.score.ToString();
    }
}
