// Copyright 2008 MbUnit Project - http://www.mbunit.com/
// Portions Copyright 2000-2004 Jonathan De Halleux, Jamie Cansdale
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// Copyright 2007 MbUnit Project - http://www.mbunit.com/
// Portions Copyright 2000-2004 Jonathan De Halleux, Jamie Cansdale
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using Gallio.Model;

namespace Gallio.Icarus.Core.CustomEventArgs 
{
    public class GetTestTreeEventArgs : EventArgs
    {
        private readonly string mode;
        private readonly bool reloadTestModelData;
        private readonly bool initialCheckState;
        private readonly TestPackageConfig testPackageConfig;

        public GetTestTreeEventArgs(string mode, bool reloadTestModelData)
        {
            this.mode = mode;
            this.reloadTestModelData = reloadTestModelData;
        }

        public GetTestTreeEventArgs(string mode, bool reloadTestModelData, bool initialCheckState, TestPackageConfig testPackageConfig)
            : this(mode, reloadTestModelData)
        {
            this.initialCheckState = initialCheckState;
            this.testPackageConfig = testPackageConfig;
        }

        public string Mode
        {
            get { return mode; }
        }

        public bool ReloadTestModelData
        {
            get { return reloadTestModelData; }
        }

        public bool InitialCheckState
        {
            get { return initialCheckState; }
        }

        public TestPackageConfig TestPackageConfig
        {
            get { return testPackageConfig; }
        }
    }
}