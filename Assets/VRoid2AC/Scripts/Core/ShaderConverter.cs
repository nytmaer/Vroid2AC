using UnityEngine;
using System.Collections.Generic;
using static VRoid2AC.Core.MaterialAnalyzer;

namespace VRoid2AC.Core
{
    public class ShaderConverter : MonoBehaviour
    {
        public enum TargetPlatform
        {
            Vanilla,
            CSP
        }

        [System.Serializable]
        public class ConvertedMaterial
        {
            public string shaderName;
            public Dictionary<string, string> texturePaths = new Dictionary<string, string>();
            public Dictionary<string, object> properties = new Dictionary<string, object>();
            public bool requiresCSP;
        }

        public ConvertedMaterial Convert(MaterialAnalysis analysis, TargetPlatform platform)
        {
            var converted = new ConvertedMaterial();
            
            converted.shaderName = SelectOptimalShader(analysis, platform);
            converted.requiresCSP = IsCSPShader(converted.shaderName);
            
            return converted;
        }

        private string SelectOptimalShader(MaterialAnalysis analysis, TargetPlatform platform)
        {
            if (platform == TargetPlatform.CSP)
            {
                if (analysis.features.HasFlag(MaterialFeatures.Metallic))
                    return "smCarPaint";
                if (analysis.features.HasFlag(MaterialFeatures.Emission))
                    return "ksPerPixelMultiMap_emissive";
            }
            
            if (analysis.features.HasFlag(MaterialFeatures.Transparency))
                return "ksPerPixelMultiMap_AT";
            if (analysis.features.HasFlag(MaterialFeatures.NormalMapping))
                return "ksPerPixelMultiMap";
            
            return "ksPerPixel";
        }

        private bool IsCSPShader(string shaderName)
        {
            string[] cspShaders = { "smCarPaint", "ksPerPixelMultiMap_NMDetail" };
            return System.Array.Exists(cspShaders, shader => shader == shaderName);
        }
    }
}
