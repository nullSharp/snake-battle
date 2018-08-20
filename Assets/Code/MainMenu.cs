using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour {

	[SerializeField] private Button _mySnakesButton;

	// Use this for initialization
	private void Start () {
		_mySnakesButton.onClick.AddListener (() => SceneManager.LoadScene ("Snakes"));
	}


	private void OnDestroy () {
		_mySnakesButton.onClick.RemoveAllListeners ();
	}

}
