using System;
using System.Collections.Generic;


namespace Code {

    public class Repo <T> {

        public HashSet <T> Items = new HashSet <T> ();


        public event Action <T> OnItemAdded;


        public void AddItem (T item) {
            Items.Add (item);
            if (OnItemAdded != null) OnItemAdded (item);
        }

    }

}