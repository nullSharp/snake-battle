using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace Code {

    public class InstantToggle : Toggle {

        public override void OnPointerDown (PointerEventData eventData) {
            base.OnPointerClick (eventData);
        }


        public override void OnPointerClick (PointerEventData eventData) {}

    }

}