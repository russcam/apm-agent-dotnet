﻿// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System.IO;
using Elastic.Apm.Report;
using Elastic.Apm.Test.Extensions;
using FluentAssertions;
using Xunit;

namespace Elastic.Apm.DockerTests
{
	public class BasicDockerTests
	{
		[Fact]
		[Category("docker")]
		public void ContainerIdExistsTest()
		{
			if (!File.Exists("/proc/self/cgroup")) return; //only run in Docker

			using (var agent = new ApmAgent(new AgentComponents()))
			{
				var payloadSender = agent.PayloadSender as PayloadSenderV2;
				payloadSender.Should().NotBeNull();
				payloadSender?.System.Should().NotBeNull();
				payloadSender?.System.Container.Should().NotBeNull();
				payloadSender?.System.Container.Id.Should().NotBeNullOrWhiteSpace();
			}
		}
	}
}
