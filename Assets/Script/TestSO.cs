/* Created by and for usage of FF Studios (2021). */

using UnityEngine;

[ CreateAssetMenu( fileName = "testSO", menuName = "FF/TestSO" ) ]
public class TestSO : ScriptableObject, ISomeInterface
{
	void ISomeInterface.Execute()
	{
		Debug.Log( name + ": TestSO.Execute() was called (TestSO inherits from SO & implements ISomeInterface)" );
	}
}
