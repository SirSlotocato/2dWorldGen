using UnityEngine;

namespace SlotoSir.Structures.Vectors
{
    /// <summary>
    /// A custom vector2 implementation(need to avoid shitty unity vector construction in every operation)
    /// </summary>
    public struct vector2
    {
        public float x, y;
        
        /// <summary>
        /// Construct a vector2 with the given x and y parameters
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public vector2(Vector2 unityVector)
        {
            x = unityVector.x;
            y = unityVector.y;
        }
    }
}