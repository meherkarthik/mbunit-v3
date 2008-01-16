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

using System.Reflection;
using Gallio.Reflection;
using Gallio.Reflection.Impl;
using JetBrains.ReSharper.Psi;

namespace Gallio.ReSharperRunner.Reflection.Impl
{
    internal sealed class PsiEventWrapper : PsiMemberWrapper<IEvent>, IEventInfo
    {
        public PsiEventWrapper(PsiReflector reflector, IEvent target)
            : base(reflector, target)
        {
        }

        public override CodeElementKind Kind
        {
            get { return CodeElementKind.Event; }
        }

        public override MemberInfo ResolveMemberInfo(bool throwOnError)
        {
            return Resolve(throwOnError);
        }

        public IMethodInfo AddMethod
        {
            get { return Reflector.Wrap(Target.Adder); }
        }

        public IMethodInfo RaiseMethod
        {
            get { return Reflector.Wrap(Target.Raiser); }
        }

        public IMethodInfo RemoveMethod
        {
            get { return Reflector.Wrap(Target.Remover); }
        }

        public EventInfo Resolve(bool throwOnError)
        {
            return ReflectorResolveUtils.ResolveEvent(this, throwOnError);
        }

        public bool Equals(IEventInfo other)
        {
            return Equals((object)other);
        }
    }
}