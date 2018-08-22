using UnityEngine;
using UnityEngine.UI;


namespace Code {

    public class MySnakesMenu : MonoBehaviour {

        [SerializeField] private ToggleGroup _toggleGroup;
        [SerializeField] private GameObject _snakeButtonPrefab;
        [SerializeField] private Transform _list;


        private void Start () {
            LoadSnakes ();
        }


        private void LoadSnakes () {
            foreach (var snake in The.Snakes.Items) {
                AddSnakeButton (snake);
            }
        }


        public void AddSnakeButton () {
            AddSnakeButton(new Snake (0, "Новая змея", default(Skin), "", new Program ()));
        }


        public void AddSnakeButton (Snake snake) {
            var sb = Instantiate (_snakeButtonPrefab, _list, false).GetComponent <SnakeButton> ();
            sb.Snake = snake;
            sb.group = _toggleGroup;
        }

    }


}