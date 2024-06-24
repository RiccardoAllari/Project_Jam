using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
	IEnumerator LoadYourAsyncScene(int sceneNumber)
	{
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneNumber);

		while (!asyncLoad.isDone)
		{
			yield return null;
		}
	}
	public void MainMenu()
	{
		StartCoroutine(LoadYourAsyncScene(0));
	}
	public void Retry()
	{
		StartCoroutine(LoadYourAsyncScene(SceneManager.GetActiveScene().buildIndex));
	}
	public void NextLevel()
	{
		StartCoroutine(LoadYourAsyncScene(SceneManager.GetActiveScene().buildIndex + 1));
	}
}
