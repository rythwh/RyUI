using UnityEngine;

namespace RyUI {
	public abstract class UIElementComponent : MonoBehaviour {
		public virtual void OnCreate() {
		}

		protected virtual void OnClose() {
		}

		public void Close() => OnClose();
	}
}