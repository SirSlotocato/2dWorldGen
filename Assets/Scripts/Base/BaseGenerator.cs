using SlotoSir.Structures.Vectors;
using UnityEngine;

public class BaseGenerator
{
    public Texture2D noiseMap;
    
    
    public void GenerateSection(vector2 offset)
    {
           
    }
    
    public void GenerateSection(float x, float y)
    { 
        GenerateSection(new vector2(x, y));
    }
    
}
