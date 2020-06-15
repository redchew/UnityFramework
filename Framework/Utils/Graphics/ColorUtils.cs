using UnityEngine;

namespace Framework
{
    namespace Utils
    {
        public static class ColorUtils
        {
			public static Color SetAlpha(Color color, float alpha)
			{
				return new Color(color.r, color.g, color.b, alpha);
			}

			public static Color LerpRGB(Color from, Color to, float t)
            {
                return new Color(Mathf.Lerp(from.r, to.r, t), Mathf.Lerp(from.g, to.g, t), Mathf.Lerp(from.b, to.b, t), from.a);
            }

            public static Color Invert(Color color)
            {
                Color.RGBToHSV(color, out float h, out float s, out float v);
                
                float hue = h + 0.5f;
                if (hue > 1f)
                    hue -= 1f;

                return Color.HSVToRGB(hue, s, v);
            }
        }
    }
}

