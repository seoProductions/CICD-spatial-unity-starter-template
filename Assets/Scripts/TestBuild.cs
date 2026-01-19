using UnityEngine;
using System;

namespace SpatialSys.UnitySDK.Editor
{
    public class TestBuild : MonoBehaviour
    {


        // Start is called before the first frame update
        public static void testFunction()
        {
            Debg("Test function Called Sucessfully!");
            Console.WriteLine("Test function Called Sucessfully!");
        }
    }
}
