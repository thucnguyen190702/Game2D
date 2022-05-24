using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBoard : MonoBehaviour
{
    public GameObject[,] squares = new GameObject[7, 7];
    public GameObject titlePre;
	public GameObject parentObj;
    public Material whiteMat, blackMat;
	//public Material whitePieceMat, blackPieceMat;
	// Start is called before the first frame update
	public void CreateBoardGame()
	{
        for(int i = 0; i < 7; i++) {
            for(int j = 0; j < 7; j++) {
                squares[i, j] = Instantiate(titlePre, new Vector3(i, j, 0), Quaternion.identity);
				squares[i, j].transform.parent = parentObj.transform;
				squares[i, j].transform.localPosition = new Vector3(i, j, 0);
				if(i % 2 != 0 && j % 2 != 0 || i % 2 == 0 && j % 2 == 0) {
					squares[i, j].GetComponent<Renderer>().material = whiteMat;
				}
				//else {
				//	squares[i, j].GetComponent<Renderer>().material = blackMat;
				//}
				squares[i, j].transform.SetParent(gameObject.transform);
			}
		}
	}
}
