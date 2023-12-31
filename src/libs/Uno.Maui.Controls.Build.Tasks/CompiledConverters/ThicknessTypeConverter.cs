using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.Maui.Controls.Build.Tasks;
using Microsoft.Maui.Controls.Xaml;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Microsoft.Maui.Controls.XamlC
{
	class ThicknessTypeConverter : ICompiledTypeConverter
	{
		public IEnumerable<Instruction> ConvertFromString(string value, ILContext context, BaseNode node)
		{
			var module = context.Body.Method.Module;

			if (!string.IsNullOrEmpty(value))
			{
				double l, t, r, b;
				var thickness = value.Split(',');
				switch (thickness.Length)
				{
					case 1:
						if (double.TryParse(thickness[0], NumberStyles.Number, CultureInfo.InvariantCulture, out l))
							return GenerateIL(context, module, l);
						break;
					case 2:
						if (double.TryParse(thickness[0], NumberStyles.Number, CultureInfo.InvariantCulture, out l) &&
							double.TryParse(thickness[1], NumberStyles.Number, CultureInfo.InvariantCulture, out t))
							return GenerateIL(context, module, l, t);
						break;
					case 4:
						if (double.TryParse(thickness[0], NumberStyles.Number, CultureInfo.InvariantCulture, out l) &&
							double.TryParse(thickness[1], NumberStyles.Number, CultureInfo.InvariantCulture, out t) &&
							double.TryParse(thickness[2], NumberStyles.Number, CultureInfo.InvariantCulture, out r) &&
							double.TryParse(thickness[3], NumberStyles.Number, CultureInfo.InvariantCulture, out b))
							return GenerateIL(context, module, l, t, r, b);
						break;
				}
			}
			throw new BuildException(BuildExceptionCode.Conversion, node, null, value, typeof(Thickness));
		}

		IEnumerable<Instruction> GenerateIL(ILContext context, ModuleDefinition module, params double[] args)
		{
			foreach (var d in args)
				yield return Instruction.Create(OpCodes.Ldc_R8, d);
			yield return Instruction.Create(OpCodes.Newobj, module.ImportCtorReference(context.Cache, ("Microsoft.Maui", "Microsoft.Maui", "Thickness"), parameterTypes: args.Select(a => ("mscorlib", "System", "Double")).ToArray()));
		}
	}

}