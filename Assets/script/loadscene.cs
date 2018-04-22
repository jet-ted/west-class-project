using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour 
{
	public void artbutton()
	{
		SceneManager.LoadScene(2, LoadSceneMode.Single);
	}

	public void startscene()
	{
		SceneManager.LoadScene (1, LoadSceneMode.Additive);
	}

	public void resetscene()
	{
		SceneManager.LoadScene (0, LoadSceneMode.Single);
	}
}
