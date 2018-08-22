using UnityEngine;


namespace Code {

    public class MySnakesMenu : MonoBehaviour {

        [SerializeField] private GameObject _snakeButtonPrefab;
        [SerializeField] private Transform _list;


        private void LoadSnakes () {
            foreach (var snake in The.Snakes.Items) {
                AddSnakeButton (snake);
            }
        }


        private void AddSnakeButton (Snake snake) {
            Instantiate (_snakeButtonPrefab, _list, false).
            GetComponent <SnakeButton> ().
            Snake = snake;
        }

    }


}