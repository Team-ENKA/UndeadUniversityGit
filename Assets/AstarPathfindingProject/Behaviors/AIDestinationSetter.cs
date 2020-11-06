using UnityEngine;
using System.Collections;

namespace Pathfinding {
	/// <summary>
	/// Sets the destination of an AI to the position of a specified object.
	/// This component should be attached to a GameObject together with a movement script such as AIPath, RichAI or AILerp.
	/// This component will then make the AI move towards the <see cref="target"/> set on this component.
	///
	/// See: <see cref="Pathfinding.IAstarAI.destination"/>
	///
	/// [Open online documentation to see images]
	/// </summary>
	[UniqueComponent(tag = "ai.destination")]
	[HelpURL("http://arongranberg.com/astar/docs/class_pathfinding_1_1_a_i_destination_setter.php")]
	public class AIDestinationSetter : VersionedMonoBehaviour {
		/// <summary>The object that the AI should move to</summary>
		public Transform targetPlayer;
		public GameObject player;
		public Transform targetCuredZ;
		public GameObject curedZDestination;
		IAstarAI ai;
		public int target;

		void OnEnable () {
			player = GameObject.FindGameObjectWithTag("Player");
			targetPlayer = player.GetComponent<Transform>();
			curedZDestination = GameObject.FindGameObjectWithTag("curedZDestination");
			targetCuredZ = curedZDestination.GetComponent<Transform>();
			ai = GetComponent<IAstarAI>();
			// Update the destination right before searching for a path as well.
			// This is enough in theory, but this script will also update the destination every
			// frame as the destination is used for debugging and may be used for other things by other
			// scripts as well. So it makes sense that it is up to date every frame.
			if (ai != null) ai.onSearchPath += Update;
		}

		void OnDisable () {
			if (ai != null) ai.onSearchPath -= Update;
		}

		/// <summary>Updates the AI's destination every frame</summary>
		void Update () {
			if (target == 0)
            {

				if(targetPlayer != null && ai != null) ai.destination = targetPlayer.position;

			}

			if (target == 1)
			{

				if (targetCuredZ != null && ai != null) ai.destination = targetCuredZ.position;

			}

		}

		public void ChangeTarget()
        {

			if (target == 1)
				target = 0;
			else
				target = 1;

        }

	}
}
