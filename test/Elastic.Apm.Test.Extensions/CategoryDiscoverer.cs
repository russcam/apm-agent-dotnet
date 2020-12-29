// Licensed to Elasticsearch B.V under
// one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.Collections.Generic;
using System.Linq;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Elastic.Apm.Test.Extensions
{
	/// <summary>
	/// This class discovers all of the tests and test classes that have
	/// applied the Category attribute
	/// </summary>
	public class CategoryDiscoverer : ITraitDiscoverer
	{
		/// <summary>
		/// Gets the trait values from the Category attribute.
		/// </summary>
		/// <param name="traitAttribute">The trait attribute containing the trait values.</param>
		/// <returns>The trait values.</returns>
		public IEnumerable<KeyValuePair<string, string>> GetTraits(IAttributeInfo traitAttribute)
		{
			var name = traitAttribute.GetNamedArgument<string>("Name");
			yield return new KeyValuePair<string, string>("Category", name);
		}
	}
}
