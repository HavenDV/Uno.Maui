#nullable disable
using System;

namespace Microsoft.Maui.Controls
{
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class ParameterAttribute : Attribute
	{
		public ParameterAttribute(string name)
		{
			Name = name;
		}

		public string Name { get; }
	}
}