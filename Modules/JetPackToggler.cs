using UnityEngine;
using Pathea;
using Pathea.ModuleNs;

namespace PortiaHelper.Modules
{
	class JetPackToggler : MonoBehaviour
	{
		void Update() {
			if (Input.GetKeyUp(KeyCode.BackQuote)) {
				Module<Player>.Self.ToggleJetPack();
			}
		}
	}
}
