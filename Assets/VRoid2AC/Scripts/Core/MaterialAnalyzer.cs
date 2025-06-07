using UnityEngine;
using System.Collections.Generic;

namespace VRoid2AC.Core
{
    public class MaterialAnalyzer : MonoBehaviour
    {
        [System.Serializable]
        public class MaterialAnalysis
        {
            public string materialName;
            public string shaderType;
            public Dictionary<string, Texture> textures = new Dictionary<string, Texture>();
            public Dictionary<string, float> floatProperties = new Dictionary<string, float>();
            public Dictionary<string, Color> colorProperties = new Dictionary<string, Color>();
            public MaterialFeatures features;
        }

        [System.Flags]
        public enum MaterialFeatures
        {
            None = 0,
            Transparency = 1,
            Emission = 2,
            NormalMapping = 4,
            Metallic = 8,
            DetailMapping = 16,
            ToonShading = 32
        }

        public MaterialAnalysis AnalyzeMaterial(Material material)
        {
            var analysis = new MaterialAnalysis
            {
                materialName = material.name,
                shaderType = DetectShaderFamily(material.shader.name),
                textures = ExtractTextures(material),
                floatProperties = ExtractFloatProperties(material),
                colorProperties = ExtractColorProperties(material),
                features = DetectFeatures(material)
            };

            return analysis;
        }

        private string DetectShaderFamily(string shaderName)
        {
            if (shaderName.Contains("MToon")) return "MToon";
            if (shaderName.Contains("Standard")) return "Standard";
            if (shaderName.Contains("URP")) return "URP";
            return "Unknown";
        }

        private Dictionary<string, Texture> ExtractTextures(Material material)
        {
            var textures = new Dictionary<string, Texture>();
            
            string[] textureProps = { "_MainTex", "_BumpMap", "_EmissionMap", "_MetallicGlossMap", "_OcclusionMap" };
            
            foreach (var prop in textureProps)
            {
                if (material.HasProperty(prop))
                {
                    var tex = material.GetTexture(prop);
                    if (tex != null) textures[prop] = tex;
                }
            }
            
            return textures;
        }

        private Dictionary<string, float> ExtractFloatProperties(Material material)
        {
            var props = new Dictionary<string, float>();
            
            string[] floatProps = { "_Metallic", "_Smoothness", "_Cutoff", "_Mode" };
            
            foreach (var prop in floatProps)
            {
                if (material.HasProperty(prop))
                {
                    props[prop] = material.GetFloat(prop);
                }
            }
            
            return props;
        }

        private Dictionary<string, Color> ExtractColorProperties(Material material)
        {
            var props = new Dictionary<string, Color>();
            
            string[] colorProps = { "_Color", "_EmissionColor", "_SpecColor" };
            
            foreach (var prop in colorProps)
            {
                if (material.HasProperty(prop))
                {
                    props[prop] = material.GetColor(prop);
                }
            }
            
            return props;
        }

        private MaterialFeatures DetectFeatures(Material material)
        {
            var features = MaterialFeatures.None;

            if (material.HasProperty("_Mode") && material.GetFloat("_Mode") >= 2)
                features |= MaterialFeatures.Transparency;

            if (material.HasProperty("_EmissionColor") && 
                material.GetColor("_EmissionColor") != Color.black)
                features |= MaterialFeatures.Emission;

            if (material.GetTexture("_BumpMap") != null)
                features |= MaterialFeatures.NormalMapping;

            if (material.HasProperty("_Metallic") && 
                material.GetFloat("_Metallic") > 0.1f)
                features |= MaterialFeatures.Metallic;

            if (material.shader.name.Contains("MToon"))
                features |= MaterialFeatures.ToonShading;

            return features;
        }
    }
}
