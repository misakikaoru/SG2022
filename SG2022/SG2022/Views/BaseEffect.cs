using System;
using Xamarin.Forms;

namespace SG2022.Views
{
	public class BaseEffect : RoutingEffect
    {
        public const string EffectNamespace = "SG2022";

        public BaseEffect(String effectId) : base($"{EffectNamespace}.{effectId}")
        {
        }
    }
}
