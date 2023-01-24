/* Created by and for usage of FF Studios (2021). */

using UnityEngine;
using Sirenix.OdinInspector;

[ CreateAssetMenu( fileName = "testSSO_", menuName = "FF/TestSSO" ) ]
public class TestSSO : SerializedScriptableObject
{
    public ISomeInterface[] interface_array;
}
