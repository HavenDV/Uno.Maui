using System.Collections.Generic;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace Microsoft.Maui.Controls.Build.Tasks
{
	static class VariableDefinitionExtensions
	{
		public static IEnumerable<Instruction> LoadAs(this VariableDefinition self, XamlCache cache, TypeReference type, ModuleDefinition module)
		{
			var implicitOperator = self.VariableType.GetImplicitOperatorTo(cache, type, module);

			yield return Instruction.Create(OpCodes.Ldloc, self);

			if (!self.VariableType.InheritsFromOrImplements(cache, type) && implicitOperator != null)
				yield return Instruction.Create(OpCodes.Call, module.ImportReference(implicitOperator));
			else if (self.VariableType.IsValueType && !type.IsValueType)
				yield return Instruction.Create(OpCodes.Box, module.ImportReference(self.VariableType));
			else if (!self.VariableType.IsValueType && type.IsValueType)
				yield return Instruction.Create(OpCodes.Unbox_Any, module.ImportReference(type));
		}
	}
}
