using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if(GameManager.instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        SceneManager.sceneLoaded += LoadState;
    }

    //resources
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    //references
    public Player player;
    //public weapon weapon...
    public FloatingTextManager floatingTextManager;

    //Logic
    public int dollas;
    public int experience;

    public void ShowText(string msg, int fontSize, Color color, Vector3 position, Vector3 motion, float duration)
    {
        floatingTextManager.Show(msg, fontSize, color, position, motion, duration);
    }

    //Save state
    /*
    *INT preferredSkin
    *INT pesos
    *INT experience
    *INT weaponLevel
    */
    public void SaveState()
    {
        Debug.Log("SaveState");
        
        string s = " ";

        s += "0" + "|";
        s += dollas.ToString() + "|";
        s += experience.ToString() + "|";
        s += "0";

        PlayerPrefs.SetString("SaveState", s);
        Debug.Log(PlayerPrefs.GetString("SaveState"));
    }

    public void LoadState(Scene s, LoadSceneMode mode)
    {
        

        if (!PlayerPrefs.HasKey("SaveState"))
            return;

        string[] data = PlayerPrefs.GetString("SaveState").Split('|');

        //Change player skin

        dollas = int.Parse(data[1]);
        experience = int.Parse(data[2]);

        Debug.Log("LoadState");
    }
}
