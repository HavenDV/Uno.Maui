#nullable disable
using System.Diagnostics;

namespace Microsoft.Maui.Controls
{
	[DebuggerDisplay("RequestDefinition = {Request}, StackRequest = {StackRequest}")]
	internal class ShellNavigationRequest
	{
		public enum WhatToDoWithTheStack
		{
			ReplaceIt,
			PushToIt
		}

		public ShellNavigationRequest(RequestDefinition definition, WhatToDoWithTheStack stackRequest, string query, string fragment)
		{
			StackRequest = stackRequest;
			Query = query;
			Fragment = fragment;
			Request = definition;
		}

		public WhatToDoWithTheStack StackRequest { get; }
		public string Query { get; }
		public string Fragment { get; }
		public RequestDefinition Request { get; }
	}
}
