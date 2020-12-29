// Licensed to Elasticsearch B.V under
// one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System;
using Xunit.Sdk;

namespace Elastic.Apm.Test.Extensions
{
	/// <summary>
	/// Categorizes tests to allow inclusion/exclusion using trait arguments
	/// </summary>
	[TraitDiscoverer("Elastic.Apm.Test.Extensions.CategoryDiscoverer", "Elastic.Apm.Test.Extensions")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
	public class CategoryAttribute : Attribute, ITraitAttribute
	{
		public CategoryAttribute(string name) => Name = name;

		public string Name { get; }
	}
}
