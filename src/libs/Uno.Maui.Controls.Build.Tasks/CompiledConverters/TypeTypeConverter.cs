using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.Maui.Controls.Build.Tasks;
using Microsoft.Maui.Controls.Xaml;
using Mono.Cecil.Cil;
using static Mono.Cecil.Cil.Instruction;
using static Mono.Cecil.Cil.OpCodes;

namespace Microsoft.Maui.Controls.XamlC
{
	class TypeTypeConverter : ICompiledTypeConverter
	{
		public IEnumerable<Instruction> ConvertFromString(string value, ILContext context, BaseNode node)
		{
			var module = context.Body.Method.Module;

			if (string.IsNullOrEmpty(value))
				goto error;

			var split = value.Split(':');
			if (split.Length > 2)
				goto error;

			XmlType xmlType;
			if (split.Length == 2)
				xmlType = new XmlType(node.NamespaceResolver.LookupNamespace(split[0]), split[1], null);
			else
				xmlType = new XmlType(node.NamespaceResolver.LookupNamespace(""), split[0], null);

			var typeRef = xmlType.GetTypeReference(context.Cache, module, (IXmlLineInfo)node);
			if (typeRef == null)
				goto error;

			yield return Create(Ldtoken, module.ImportReference(typeRef));
			yield return Create(Call, module.ImportMethodReference(context.Cache, ("mscorlib", "System", "Type"),
																   methodName: "GetTypeFromHandle",
																   parameterTypes: new[] { ("mscorlib", "System", "RuntimeTypeHandle") },
																   isStatic: true));

			yield break;

		error:
			throw new BuildException(BuildExceptionCode.Conversion, node, null, value, typeof(Type));
		}
	}
}