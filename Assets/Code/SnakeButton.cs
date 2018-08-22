using UnityEngine.UI;


namespace Code {

    public class SnakeButton : InstantToggle {

        private Snake _snake;
        private Text  _textField;


        private void Awake () {
            _textField = GetComponentInChildren <Text> ();
        }


        public Snake Snake {
            get { return _snake; }
            set {
                _snake          = value;
                _textField.text = _snake.Name;
            }
        }

    }

}