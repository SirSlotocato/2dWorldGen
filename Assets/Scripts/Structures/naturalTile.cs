
using System;
using System.Collections.Generic;
using SlotoSir.Structures.Vectors;
using UnityEngine;
using Vector2 = SlotoSir.Structures.Vectors.vector2;

namespace SlotoSir.Structures.Tiles
{
    [Serializable]
    public class baseTile
    {
        public Texture2D tileTexture;
        [HideInInspector] public vector2 squareDimensions;

        protected vector2 standardDims = new vector2(1.0f, 1.0f);
        
        public baseTile(Texture2D texture)
        {
            tileTexture = texture;
            //TODO change the setted value of squareDimensions with one based on a manager
            squareDimensions = standardDims;
        }
        
    }

    [Serializable]
    public class distantiatedTile : baseTile
    {
        public Dictionary<baseTile, float> minTileDistance = new Dictionary<baseTile, float>();


        public distantiatedTile(Texture2D texture) : base(texture)
        {
            tileTexture = texture;
            //TODO change the setted value of squareDimensions with one based on a manager
            squareDimensions = standardDims;
        }
        public distantiatedTile(Texture2D texture, Dictionary<baseTile, float> tileDistance) : base(texture)
        {
            tileTexture = texture;
            //TODO change the setted value of squareDimensions with one based on a manager
            squareDimensions = standardDims;
            minTileDistance = tileDistance;
        }
    }
    
}