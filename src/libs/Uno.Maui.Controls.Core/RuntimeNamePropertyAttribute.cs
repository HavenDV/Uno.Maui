#nullable disable
using System;

namespace Microsoft.Maui.Controls.Xaml
{
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class RuntimeNamePropertyAttribute : Attribute
	{
		public RuntimeNamePropertyAttribute(string name)
		{
			Name = name;
		}

		public string Name { get; }
	}
}