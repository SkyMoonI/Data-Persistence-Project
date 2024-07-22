using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
	[SerializeField] TextMeshProUGUI bestScoreText;

	[SerializeField] Button start;
	[SerializeField] Button quit;

	public void ReadPlayerNameInput(string name)
	{
		MenuManager.Instance.playerName = name;
	}
	public void StartGame()
	{
		SceneManager.LoadScene(1);
	}
	public void QuitGame()
	{
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
	}
}
