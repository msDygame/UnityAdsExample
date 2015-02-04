using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;//for Unity Ads

public class TestUnityAds : MonoBehaviour 
{
    private string LogMsg = "LogMsg : ";
	private bool IsAds = false;
    public string gameId = "131624605";//your game ID , Ex:"131624605" = NineGridPuzzle.apk
    void Awake () 
    {
		// parm : GameID, Is testMode.
        Advertisement.Initialize(gameId , true);
	}
	// Use this for initialization
	void Start () 
    {
	
	}	
	// Update is called once per frame
	void Update () 
    {
	    if(Advertisement.isReady() && !IsAds)
		{
			Advertisement.Show();
			LogMsg = "LogMsg : Advertisement.Show";
			IsAds = true;
		}
		else if(!IsAds)
		{
			LogMsg = "LogMsg : Wait...";
		}
	}

	void OnGUI () 
    {
		GUI.Label(new Rect(0,0,800,100), LogMsg);

        if (GUI.Button(new Rect(10, 110, 100, 100), "Quit"))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
	}
}
