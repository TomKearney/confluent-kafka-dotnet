// Copyright 2016-2017 Confluent Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// Refer to LICENSE for more information.

using Xunit;


namespace Confluent.Kafka.Tests
{
    public class BrokerMetadataTest
    {
        [Fact]
        public void Constuctor()
        {
            var bm = new BrokerMetadata(42, "myhost", 8080);
            Assert.Equal(bm.BrokerId, 42);
            Assert.Equal(bm.Host, "myhost");
            Assert.Equal(bm.Port, 8080);
        }

        [Fact]
        public void ToStringTest()
        {
            var bm = new BrokerMetadata(42, "myhost", 8080);
            Assert.True(bm.ToString().Contains(42.ToString()));
            Assert.True(bm.ToString().Contains("myhost"));
            Assert.True(bm.ToString().Contains(8080.ToString()));

            // TODO: JSON based test. Note: there is coverage of this already in the Metdata integration test.
        }
    }
}

