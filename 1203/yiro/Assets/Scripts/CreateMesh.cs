using UnityEngine;
using System.Collections;

[RequireComponent (typeof(MeshRenderer))]
[RequireComponent (typeof(MeshFilter))]

[ExecuteInEditMode]
public class CreateMesh : MonoBehaviour {

	[SerializeField]
	private Material material;

	// Use this for initialization
	void Start () {
	
		var mesh = new Mesh( );

		mesh.vertices = new Vector3[] {

			new Vector3( 0, 1f ),
			new Vector3( 1f, -1f ),
			new Vector3( -1f, -1f ),
		};

		mesh.triangles = new int[] {
			0,1,2	
		};

		/*mesh.uv = new Vector2[]{ 
			new Vector2(0.5f, 1f),
			new Vector2(1f, 0),
			new Vector2(0,0),
		};*/

		mesh.colors = new Color[]{ 
			Color.red,
			Color.blue,
			Color.green
		};

		var filter = GetComponent<MeshFilter>( );
		filter.sharedMesh = mesh;

		var render = GetComponent<MeshRenderer>( );
		render.sharedMaterial = material;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
