using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Director : MonoBehaviour
{
    private List<Bus> inimigos = new List<Bus>();
    private PlayerControl player1;
    private PlayerControler2 player2;
    [SerializeField]
    public GameObject gameTitle;
    [SerializeField]
    public GameObject gameUserIterface;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var Bus in GameObject.FindObjectsOfType<Bus>())
        {
            inimigos.Add(Bus);
        }

        player1 = GameObject.FindObjectOfType<PlayerControl>();

        player2 = GameObject.FindObjectOfType<PlayerControler2>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            gameTitle.SetActive(false);

            gameUserIterface.SetActive(true);

            foreach(var bus in inimigos)
            {
                bus.SetStartEnemies(true);
            }

            player1.SetStartPlayer(true);

            player2.SetStartPlayer(true);
        }
    }
}
