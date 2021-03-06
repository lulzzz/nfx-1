/*<FILE_LICENSE>
* NFX (.NET Framework Extension) Unistack Library
* Copyright 2003-2018 Agnicore Inc. portions ITAdapter Corp. Inc.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
</FILE_LICENSE>*/
using System;

namespace NFX
{
  /// <summary>
  /// Represents a special value that signifies the absence of any entity/state/value/data.
  /// The instances may be stored in a cache to indicate that the key exists, but points to a non-existing "absent" entity.
  /// This is usefull for DB lookups, not to touch the backend for values that dont exist.
  /// Use AbsentValue.Instance singleton
  /// </summary>
  [Serializable]
  public sealed class AbsentValue
  {
    public static readonly AbsentValue Instance = new AbsentValue();

    private AbsentValue(){}

    public override int GetHashCode() { return 0; }
    public override bool Equals(object obj) { return obj is AbsentValue;}
    public override string ToString(){ return "[Absent]";}
  }
}
