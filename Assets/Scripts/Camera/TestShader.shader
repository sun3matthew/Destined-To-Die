Shader "Hidden/TestShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        // No culling or depth
        Cull Off ZWrite Off ZTest Always

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = v.uv;
                return o;
            }

            sampler2D _MainTex;

            fixed4 glitch;
            float offsetUpAmt;
            float offsetDownAmt;

            float grayscale;

            float r,g,b;

            fixed4 frag (v2f i) : SV_Target
            {

                fixed4 col = tex2D(_MainTex, i.uv);
                fixed4 offsetUp = tex2D(_MainTex, i.uv + glitch * 0.01);
			    fixed4 offsetDown = tex2D(_MainTex,  i.uv - glitch * 0.01);

                col += fixed4(offsetUp.r, offsetUp.b, offsetUp.g, 1) * offsetUpAmt;
                col *= 1 - 0.5 * offsetUpAmt;
			    col += fixed4(offsetDown.g, offsetDown.b, offsetDown.r, 1) * offsetDownAmt;
                col *= 1 - 0.5 * offsetDownAmt;


                col += fixed4(r,g,b,1);
   
                fixed avgG = (col.r + col.g + col.b)/3;
                col += fixed4((col.r - avgG)*grayscale, (col.g - avgG)*grayscale, (col.b - avgG)*grayscale, 0);
                return col;
            }
            ENDCG
        }
    }
}
