#pragma warning disable 618 // Ignore obsolete members warnings
using System;
using System.Linq;
using System.Diagnostics;
using XamlGenerationTests;

namespace XamlGenerationTests.Shared
{
	public sealed partial class CustomControlWithContent
	{
		public void CheckBackingFields()
		{
			// Placeholder method present to check that the generated code declares these fields.
			var a = this.ImplicitContentTextBox;
			var b = ExplicitContentTextBox;
			var d = IfDataContextContentTextBox;
		}
	}
}
